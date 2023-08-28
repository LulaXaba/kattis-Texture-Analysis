using System;

class Program
{
    static bool IsEvenlySpaced(string line)
    {
        int count = 0;

        // Count the number of black pixels in the line
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '*')
            {
                count++;
            }
        }

        // If there are no or only one black pixel, the line is considered evenly spaced
        if (count <= 1)
            return true;

        // Store the indices of the black pixels in an array
        int[] blackIndices = new int[count];
        int index = 0;

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '*')
            {
                blackIndices[index] = i;
                index++;
            }
        }

        // Calculate the lengths of the white spaces between the black pixels
        int[] whiteLengths = new int[count - 1];
        for (int i = 0; i < count - 1; i++)
        {
            whiteLengths[i] = blackIndices[i + 1] - blackIndices[i];
        }

        // Check if all the white spaces have the same length
        int firstWhiteLength = whiteLengths[0];
        foreach (int length in whiteLengths)
        {
            if (length != firstWhiteLength)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int line_number = 1;
        
        // Read a line from the console
        string line = Console.ReadLine();

        while (line != null && line != "END")
        {
            // Check if the line is evenly spaced
            if (IsEvenlySpaced(line))
            {
                Console.WriteLine($"{line_number} EVEN");
            }
            else
            {
                Console.WriteLine($"{line_number} NOT EVEN");
            }

            // Read the next line from the console
            line_number++;
            line = Console.ReadLine();
        }
    }
}


// - The code defines a class called `Program` within the `System` namespace.
// - The `IsEvenlySpaced` method takes a string `line` as input and determines whether the black pixels in the line are evenly spaced.
// - The method counts the number of black pixels in the line by iterating over each character and incrementing the `count` variable.
// - If there are no or only one black pixel, the method returns `true` to indicate that the line is considered evenly spaced.
// - If there are more than one black pixel, the method stores the indices of the black pixels in the `blackIndices` array.
// - It then calculates the lengths of the white spaces between the black pixels and stores them in the `whiteLengths` array.
// - The method checks if all the white spaces have the same length by comparing each length with the first length in the array.
// - If any length is different, it means the black pixels are not evenly spaced, and the method returns `false`.
// - Otherwise, if all the white spaces have the same length, the method returns `true` indicating that the black pixels are evenly spaced.

// - The `Main` method is the entry point of the program.
// - It initializes a variable `line_number` to keep track of the line number.
// - It reads a line from the console using `Console.ReadLine()`.
// - Inside the `while` loop, it checks if the line is not `null` and not equal to `"END"`.
// - It then calls the `IsEvenlySpaced` method to determine if the line is evenly spaced.
// -Depending on the result, it prints the line number along with the appropriate message using Console.WriteLine().

// It increments the line number and reads the next line from the console.

// The loop continues until either the line is null or equal to "END".





i remeber tha i wr 


