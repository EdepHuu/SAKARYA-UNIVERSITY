import java.util.Random;
public class Color {
    public static final String RESET = "\033[0m";

    // create a random object for random values
    private static Random random = new Random();

    // create a method that create blue , green and red values and use them to create a color
    public static String getRandomColor() {
        int red, green, blue;
        do {
            red = random.nextInt(256);
            green = random.nextInt(256);
            blue = random.nextInt(256);
        } while (red + green + blue < 200); // make sure the color is not too dark for readability purposes :)
        return "\033[38;2;" + red + ";" + green + ";" + blue + "m";
    }

    public static void setColor(String color) {
        System.out.print(color);
    }

    public static void resetColor() {
        System.out.print(RESET);
    }
}
