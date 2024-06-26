// enter input array and k value from console
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int k = int.Parse(Console.ReadLine());

int n = input.Length;
int[] sum = new int[n];

// start rotation
for (int r = 1; r <= k; r++)
{
    int[] rotated = new int[n];

    for (int i = 0; i < n; i++)
    {
        rotated[(i + r) % n] = input[i];

    }

    // get sum
    for (int j = 0; j < n; j++)
    {
        sum[j] += rotated[j];
    }

    // result show
    Console.WriteLine(string.Join(" ", sum));
}


