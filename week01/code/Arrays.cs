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

        // To solve this problem, I first declare a list of doubles to hold the multiples
        // Then, I will use a for loop to iterate through the number of multiples required
        // Inside the for loop, a double variable named multiple will calculate the multiple
        // After that, the number will be added to the multiples List for each iteration using the .Add() method
        // Lastly as the function is an array of double, we will convert the List to an Array using .toArray() method
        List<double> multiples = new();
        for (int i = 1; i <= length; ++i) {
            double multiple = number * i;
            multiples.Add(multiple);
        } 

        return multiples.ToArray(); // replace this return statement with your own
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

        // To solve this problem, I will use the GetRange method for a list to slice the list
        // I will need to find the index where I will want to begin the slicing as the amount will serve as the number of 
        // item to return. The calculation of the index is the count of the list minus the amount.
        // Afterward, I will declare a list for the right datas which I will get with the .GetRange method with with the index calculated and the amount as the count
        // Then, I will get the leftData using the same method but starting at the start of the list and the count will then be replaced by the index.
        // I will then clear the existing list and append the rightData first to the cleared list and the leftData after.
        int index = data.Count - amount;
        List<int> rightData = data.GetRange(index, amount);
        List<int> leftData = data.GetRange(0, index);
        
        data.Clear();
        data.AddRange(rightData);
        data.AddRange(leftData);
    }
}
