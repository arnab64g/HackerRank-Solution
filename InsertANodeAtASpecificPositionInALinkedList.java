import java.util.LinkedList;
import java.util.Scanner;
public class InsertANodeAtASpecificPositionInALinkedList {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        LinkedList<Integer> ll = new LinkedList<>();
        int n = sc.nextInt();
        for (int i = 0; i < n; i++) {
            int value = sc.nextInt();
            ll.add(value);
        }
        int val = sc.nextInt();
        int pos = sc.nextInt();
        ll.add(pos, val);
        sc.close();  
        for (Integer integer : ll) {
            System.out.print(integer+" ");
        }   
        System.out.println();
    }
    
}