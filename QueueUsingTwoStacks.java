import java.util.Scanner;
import java.util.LinkedList;
import java.util.Queue;
class QueueUsingTwoStacks{
    public static void main(String[] args){
        Queue<Integer> q = new LinkedList<>();
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i < n; i++){
            int a = sc.nextInt();
            if(a == 1){
                int value = sc.nextInt();
                q.add(value);
            }
            else if(a == 2){
                q.remove();
            }
            else if(a == 3){
                int value = q.peek();
                System.out.println(value);
            }
        }
        sc.close();
    }
}
