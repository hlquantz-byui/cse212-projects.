public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Create an empty array with the length specified by the 'length' argument.
        // This array will hold the multiples of the specified number.

        // Step 2: Create a for loop that iterates from 1 to 'length' (inclusive).
        // This loop will be used to calculate each multiple.

        // Step 3: Multiply the 'number' argument by the loop counter (i) to get the current multiple and assign it to the array at the index of (i - 1).

        // Step 4: After the loop completes, return the array containing the multiples.
        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++)
        {
            multiples[i - 1] = number * i;
        }
        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Validate the input to ensure the amount to rotate is within the valid range
        // (i.e., between 1 and the length of the list).

        // Step 2: Get the part of the list that will be at the end
        // (the last 'amount' elements) using the GetRange method.

        // Step 3: Get the part of the list that will be at the beginning
        // (all elements except the last 'amount' elements) using the GetRange method.

        // Step 4: Combine the two parts in the correct order to get the rotated list
        // by concatenating the part to be moved to the beginning with the part to stay in order.

        // Step 5: Return the rotated list
        amount = amount % data.Count;
        if (amount < 0)
        {
            amount = data.Count + amount;
        }
        List<int> part1 = data.GetRange(0, amount);
        List<int> part2 = data.GetRange(amount, data.Count - amount);

        data.Clear();
        data.AddRange(part2.Concat(part1).ToList());

    }
}
