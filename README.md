# Words on the Waves - Unity Mobile Game Simulation

A mobile game simulating a mobile bookstore by the beach where players manage shelves, purchase book crates, travel between locations, listen to customers' stories, and recommend the correct book genres.

---

## System Flow Diagram (SFD)

Below is the system flow diagram outlining the game architecture (Finite State Machine states, input processing, matching logic, and observer events):

![System Flow](docs/system_flow.png)

### Key Flow States
1. **MainMenuState**: The home menu to navigate to other screens (Shop, Decoration, Book Management, Map Travel).
2. **CargoState / Shop**: Purchase book crates with randomized drop rates or customize the book wagon with decor items.
3. **PreparationState (Manage Book)**: Arrange book stock from storage shelves to the wagon shelves.
4. **MapTravelState**: Deducts a fuel fee and loads a selected beach location with its unique customer demographics.
5. **ServiceState**: Spawns NPCs who approach the book wagon.
   * **Autobuy Path**: Customers buy directly from the shelves for the base price if they don't need advice.
   * **Listening Event**: Tap on NPCs to listen to their dialogue. The player recommends a genre.
     * *Correct Recommendation*: Player earns book price + tips + potential Memento item.
     * *Incorrect Recommendation*: Customer leaves immediately without buying.
6. **DaySummaryState**: Summarizes the day's profit and saves progress before moving to the next day.
