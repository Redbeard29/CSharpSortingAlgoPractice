using System;

class BubbleSort{

    public static void Sort(int[] intArray){

        int sortedPartitionIdx = intArray.Length;
        bool sorted = false;

        while(sortedPartitionIdx > 0 && !sorted){
            bool swapped = false;
            for(int x = 0, y = 1; y < sortedPartitionIdx; x++, y++){
                if(intArray[x] > intArray[y]){
                    int temp = intArray[x];
                    intArray[x] = intArray[y];
                    intArray[y] = temp;
                    swapped = true;
                }
            }
            if(!swapped){
                sorted = true;
            }

            sortedPartitionIdx--;
        }

    }

}