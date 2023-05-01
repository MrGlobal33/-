
Console.Write("Введите элементы массива через пробел:  ");
        string input = Console.ReadLine() ?? "0";

        string[] inputArr = input.Split(" ");
        string[] outputArr = new string[inputArr.Length];
        int outputIndex = 0;

        foreach (var item in inputArr) {
            if (item.Length <= 3) {
                outputArr[outputIndex++] = $"\"{item}\"";
            }
        }

        Array.Resize(ref outputArr, outputIndex);
        
        Console.WriteLine($"Результат: [{string.Join(", ", outputArr)}]");