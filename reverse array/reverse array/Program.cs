int[] array = { 1, 7, 16, 5, 9 };

int element = 0;         
int reverse = array.Length-1;
int holder = 0;
while (element<reverse)
{
    //swap
    holder = array[element];
    array[element] = array[reverse];
    array[reverse] = holder;
    element++;
    reverse--;
}
int[] reverseArray = array;

for (int k = 0; k < reverseArray.Length; k++)
{
    Console.WriteLine(reverseArray[k]);
}