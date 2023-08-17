
int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };

int index = 0;

int sum = nbrs[index]
            + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index]
             + nbrs[++index];

Console.WriteLine($"Sum is {sum}");

Console.WriteLine($"Average is {sum / 10.0}");
