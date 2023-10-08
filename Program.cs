using AlgorithmHomework;

IVehicle test = new Car(500);

test.Move();
test.Move();
test.Move();
test.Move();
test.Move();
test.Refill(200);
test.Move();
test.Move();

int[] array = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(Find(-10, array));

static bool Find(int key, int[] array)
{
    int startInd = 0;
    int endInd = array.Length - 1;
    int elementInd = array.Length / 2;
   
    while (startInd <= endInd)
    {
        if (key == array[elementInd])
        {
            return true;
        }

        if (key > array[elementInd])
        {
            startInd = elementInd + 1;
        }
        else
        {
            endInd = elementInd - 1;
        }
        elementInd = startInd + (endInd - startInd) / 2;
    }    

    return false;
}