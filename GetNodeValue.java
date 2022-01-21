/**
 * GetNodeValue
 */
import java.util.LinkedList;
import java.util.Scanner;
public class GetNodeValue {

    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();
        for (int i = 0; i < t; i++) {
            int n = sc.nextInt();
            LinkedList<Integer> st = new LinkedList<>();
            for (int j = 0; j < n; j++) {
                st.addFirst(sc.nextInt());
            }
            int pos = sc.nextInt();
            System.out.println(st.get(pos));
        }
        sc.close();
    }
}