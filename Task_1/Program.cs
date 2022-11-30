string[] CreateStringArray1(int n) {  
    string[] array = new string[n]; 
        for (int i = 0; i < n; i++) {
            Console.Write("Введите элемент массива №{0}:\n", i + 1);
            array[i] = Console.ReadLine();             
    }
    return array;
}
string[] CreateStringArray2(string[] array) {
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i].Length <= 3) 
        count++;
    }
    string[] newArray = new string[count];
    for(int i = 0, j = 0; i < array.Length; i++) {
        if(array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
void PrintStringArray(string[] array) {
    Console.Write("[");
    for(int i = 0; i < array.Length; i++) {
        Console.Write("\"" + array[i] + "\"");
        if(i < array.Length -1)  
            Console.Write(", ");
    }
    Console.Write("]");
    Console.Write(" -> ");
}
Console.Write("Введите количество строк массива, которые хотите ввести:\n");
int n = Convert.ToInt32(Console.ReadLine()); 
string[] array = CreateStringArray1(n);
PrintStringArray(array);
string[] myArray = CreateStringArray2(array);
PrintStringArray(myArray);
Console.WriteLine();
Console.WriteLine("Нажмите [Enter] для выхода...");
Console.ReadLine();


