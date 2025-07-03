public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN to solve MultiplesOf function
        // 1. Create an array of size equal to the length parameter
        // 2. Use a loop that runs from 0 to length - 1
        // 3. In each iteration, multiply the number by (i + 1)
        // 4. Store the result in the corresponding index of the array
        // 5. Return the array after the loop

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN to solve RotateListRight function
        // 1. Get the last 'amount' elements from the list
        // 2. Get the first 'data.Count - amount' elements from the list
        // 3. Clear the existing list so we can reuse it
        // 4. Add the last part first, then the first part second
        // 5. The list is modified in-place, so no return is needed

        int count = data.Count;

        var rightPart = data.GetRange(count - amount, amount);
        var leftPart = data.GetRange(0, count - amount);

        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
