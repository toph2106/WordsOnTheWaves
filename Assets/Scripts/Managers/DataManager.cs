using UnityEngine;
using System.IO;
using WordsOnTheWaves.Models;

namespace WordsOnTheWaves.Managers
{
    public class DataManager : MonoBehaviour
    {
        public static DataManager Instance { get; private set; }

        public GameConfigData GameConfig { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);

            LoadGameConfig();
        }

        private void LoadGameConfig()
        {
            string filePath = Path.Combine(Application.streamingAssetsPath, "GameConfig.json");

            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                GameConfig = JsonUtility.FromJson<GameConfigData>(jsonContent);

                Debug.Log("DỮ LIỆU BẢN ĐỒ");
                foreach (var map in GameConfig.mapLocations)
                {
                    Debug.Log($"- Địa điểm: {map.locationName} | Phí: {map.travelFee} | Khách mục tiêu: {string.Join(", ", map.targetAudiences)}");
                }
                
                Debug.Log("DỮ LIỆU KIỆN HÀNG SÁCH");
                foreach (var crate in GameConfig.cargoCrates)
                {
                    string drops = "";
                    foreach (var d in crate.dropRates) { drops += $"[{d.genre}: {d.rate}%] "; }
                    Debug.Log($"- Hòm: {crate.crateName} | Giá: {crate.price} | Tỷ lệ rớt sách: {drops}");
                }
            }
            else
            {
                Debug.LogError($"GameConfig.json not found at: {filePath}");
            }
        }
    }
}
