using System;
using System.Linq;

public class Program
{
	    public static int Trap(int[] height) {
        int maxHeight = height.Max();
        var matrix = new int[maxHeight,height.Length];
        for(int i = 0; i < height.Length; i++){
            if(height[i] > 0){
                for(int j = 0; j < height[i]; j++){
                    matrix[j,i] = 1;
                }
            }
        }
		PrintMatrix(matrix);
        int counter = 0;
        for(int i = 0; i < matrix.GetLength(0); i++){
            for(int j = 0; j < matrix.GetLength(1); j++){
                if(matrix[i,j] == 1){
					Console.WriteLine("element - [{0},{1}] : ",i,j);

                    int left = j;
                    int right = -1;
                    for(int k = j + 1; k < height.Length; k++) {
                        if(matrix[i,k] == 1){
						Console.WriteLine("sedcont to right - [{0},{1}] : ",i,k);
			
                            right = k;
							break;
                        }
                    }
                    if(right == -1 || right - left == 1){
                        continue;
                    }
   				Console.WriteLine("left,right - [{0},{1}] : ",left,right);

                    for(int k = left + 1; k < right; k++){
                        counter++;
                    }
                }
            }
        
        }    
         return counter;
    }
	public static void PrintMatrix(int[,] matrix){
		 int rowLength = matrix.GetLength(0);
        int colLength = matrix.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", matrix[i, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
        //Console.ReadLine();
	}
	

	public static void Main()
	{
		var arr = new int[]{4,2,0,3,2,5};
		Console.WriteLine(Trap(arr));
	}
}