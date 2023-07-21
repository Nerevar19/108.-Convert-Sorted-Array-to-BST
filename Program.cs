namespace _108._Convert_Sorted_Array_to_BST
{
    internal class Program
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static public int[] ArrayCutter(in int[] array,int startPoint, int length)
        {
            int[] resultArray = new int[length];
            for(int i = 0; i < length; i++)
            {
                resultArray[i] = array[startPoint + i];
            }
            return resultArray;
        }

        static public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0) return null;
            if(nums.Length == 1) return new TreeNode(nums[0]);
            int ptr = nums.Length / 2;

            TreeNode root = new TreeNode(nums[ptr]);
            root.left = SortedArrayToBST(ArrayCutter(in nums, 0, ptr));
            root.right = SortedArrayToBST(ArrayCutter(in nums, ptr + 1 , nums.Length % 2 == 0 ? ptr-1:ptr));
            return root;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            //SortedArrayToBST(nums);
        }
    }
}