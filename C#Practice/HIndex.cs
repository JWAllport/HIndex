// Given an array of integers citations where citations[i] is the number of citations 
// a researcher received for their ith paper, return the researcher's h-index.

// According to the definition of h-index on Wikipedia: T
// he h-index is defined as the maximum value of h such that the 
// given researcher has published at least h papers that have each been cited at least h times.

namespace HIndex {
    public class HIndex {
        public int hIndex(int[] citations) {
            List<int> tmp = new List<int>();
            int highestIndex = 0;
            for (int i =0; i< citations.Length; i++) {
                int first = citations[i];
                int count = 0;
                for (int j = 0; j < citations.Length; j++) {
                    int second = citations[j];
                    if (first !=0 && second != 0 && first <= second) {
                        count++;
                        if (count == first)
                            break;
                    }
                    
                }
                if (highestIndex < count && first == count)
                    highestIndex = count;
            }
            return highestIndex;
        }
    }

}
