public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //here one input is array , and the other is target 
        int i = 0; 
        
        int j = numbers.Length-1;

        while(i<j)//two pointers work till both pointer is not coming to a same spot
        {
            if(numbers[i]+numbers[j]==target){
                return [i+1,j+1];//this way you return the array of indices 
            }else if(numbers[i]+numbers[j]>target){
                j--;
            }else{
                i++;
            }
        }
        return [-1,-1];
        
    }
}