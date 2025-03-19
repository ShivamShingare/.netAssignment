import java.util.Scanner;

public class WaterJugGame {
    static int jug1, jug2;
    static final int CAPACITY1 = 4; // Capacity of first jug
    static final int CAPACITY2 = 3; // Capacity of second jug
    static final int TARGET = 2; // Target amount of water

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        jug1 = 0;
        jug2 = 0;

        while (jug1 != TARGET && jug2 != TARGET) {
            System.out.println("\nCurrent State: Jug1 = " + jug1 + "L, Jug2 = " + jug2 + "L");
            System.out.println("Choose an action:");
            System.out.println("1. Fill Jug 1");
            System.out.println("2. Fill Jug 2");
            System.out.println("3. Empty Jug 1");
            System.out.println("4. Empty Jug 2");
            System.out.println("5. Pour Jug 1 -> Jug 2");
            System.out.println("6. Pour Jug 2 -> Jug 1");
            System.out.println("7. Exit");
            System.out.print("Enter choice: ");
            int choice = scanner.nextInt();

            switch (choice) {
                case 1 -> jug1 = CAPACITY1; // Fill Jug 1
                case 2 -> jug2 = CAPACITY2; // Fill Jug 2
                case 3 -> jug1 = 0; // Empty Jug 1
                case 4 -> jug2 = 0; // Empty Jug 2
                case 5 -> { // Pour Jug 1 -> Jug 2
                    int transfer = Math.min(jug1, CAPACITY2 - jug2);
                    jug1 -= transfer;
                    jug2 += transfer;
                }
                case 6 -> { // Pour Jug 2 -> Jug 1
                    int transfer = Math.min(jug2, CAPACITY1 - jug1);
                    jug2 -= transfer;
                    jug1 += transfer;
                }
                case 7 -> {
                    System.out.println("Game exited.");
                    scanner.close();
                    return;
                }
                default -> System.out.println("Invalid choice! Try again.");
            }
        }
        System.out.println("Congratulations! You reached the target amount of " + TARGET + "L.");
        scanner.close();
    }
}
