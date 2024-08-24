int[] number = new int[10];


for (int i = 0; i < number.Length; i++)
{

    Console.WriteLine($"lütfen sayınızı giriniz ---> {i + 1}");
    number[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int i in number)
{
    Console.WriteLine($"\nGirdiğiniz sayılar: " +i);
}

Console.WriteLine("\nBu listeye 11.sayıyı ekleyiniz.");
int number1 = Convert.ToInt32(Console.ReadLine());

int[] newNumber = new int[number.Length + 1];

for (int i = 0; i < number.Length; i++)
{
    newNumber[i] = number[i];
}

newNumber[number.Length - 1]=number1;    // Kullanıcıdan alınan 11. elemanı yeni dizinin sonuna ekliyoruz

Console.WriteLine("New Number List");
foreach (int i in newNumber)
{
    Console.WriteLine(i);
}

newNumber[newNumber.Length - 1] = number1;

// Diziyi küçükten büyüğe sıralıyoruz
Array.Sort(newNumber);

// Diziyi büyükten küçüğe çevirmek için tersine çeviriyoruz
Array.Reverse(newNumber);

// Güncellenmiş ve sıralanmış diziyi ekrana yazdırıyoruz
Console.WriteLine("\nGüncellenmiş ve büyükten küçüğe sıralanmış sayı listesi:");
foreach (int i in newNumber)
{
    Console.WriteLine(i);
}