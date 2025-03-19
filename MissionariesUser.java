import java.util.Scanner;

public class MissionariesAndCannibals {
    static int missionariesLeft = 3, cannibalsLeft = 3;
    static int missionariesRight = 0, cannibalsRight = 0;
    static boolean boatLeft = true; // true means the boat is on the left side

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        while (!gameWon()) {
            displayState();
            System.out.print("Enter number of missionaries and cannibals to move (M C): ");
            int m = scanner.nextInt();
            int c = scanner.nextInt();
            
            if (isValidMove(m, c)) {
                moveBoat(m, c);
            } else {
                System.out.println("Invalid move! Try again.");
            }
            
            if (gameLost()) {
                System.out.println("Game Over! The cannibals outnumbered the missionaries.");
                return;
            }
        }
        
        System.out.println("Congratulations! You successfully moved everyone to the other side.");
        scanner.close();
    }
    
    static void displayState() {
        System.out.println("\nLeft Side: " + missionariesLeft + "M " + cannibalsLeft + "C  | Boat: " + (boatLeft ? "Left" : "Right") + " |  Right Side: " + missionariesRight + "M " + cannibalsRight + "C");
    }
    
    static boolean isValidMove(int m, int c) {
        if (m < 0 || c < 0 || m + c > 2 || (m == 0 && c == 0)) return false;
        if (boatLeft) {
            if (m > missionariesLeft || c > cannibalsLeft) return false;
        } else {
            if (m > missionariesRight || c > cannibalsRight) return false;
        }
        return isSafeState(m, c);
    }
    
    static boolean isSafeState(int m, int c) {
        int newML, newCL, newMR, newCR;
        if (boatLeft) {
            newML = missionariesLeft - m;
            newCL = cannibalsLeft - c;
            newMR = missionariesRight + m;
            newCR = cannibalsRight + c;
        } else {
            newML = missionariesLeft + m;
            newCL = cannibalsLeft + c;
            newMR = missionariesRight - m;
            newCR = cannibalsRight - c;
        }
        return (newML == 0 || newML >= newCL) && (newMR == 0 || newMR >= newCR);
    }
    
    static void moveBoat(int m, int c) {
        if (boatLeft) {
            missionariesLeft -= m;
            cannibalsLeft -= c;
            missionariesRight += m;
            cannibalsRight += c;
        } else {
            missionariesLeft += m;
            cannibalsLeft += c;
            missionariesRight -= m;
            cannibalsRight -= c;
        }
        boatLeft = !boatLeft;
    }
    
    static boolean gameWon() {
        return missionariesRight == 3 && cannibalsRight == 3;
    }
    
    static boolean gameLost() {
        return (missionariesLeft > 0 && missionariesLeft < cannibalsLeft) || (missionariesRight > 0 && missionariesRight < cannibalsRight);
    }
}
