import java.util.LinkedList;
import java.util.Scanner;
public class DeleteANode {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        LinkedList<Integer> ll = new LinkedList<>();
        for (int i = 0; i < n; i++) {
            ll.add(sc.nextInt());
        }
        ll.remove(sc.nextInt());
        sc.close();
        for (Integer integer : ll) {
            System.out.print(integer+" ");
        }
        System.out.println();
    }
}
