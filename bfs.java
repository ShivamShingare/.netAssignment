import java.util.*;

class Graph {
    private final Map<Integer, List<int[]>> adjList = new HashMap<>();

    public void addEdge(int from, int to, int cost) {
        adjList.computeIfAbsent(from, k -> new ArrayList<>()).add(new int[]{to, cost});
        adjList.computeIfAbsent(to, k -> new ArrayList<>()).add(new int[]{from, cost}); // For undirected graph
    }

    public List<Integer> bestFirstSearch(int start, int goal) {
        PriorityQueue<int[]> pq = new PriorityQueue<>(Comparator.comparingInt(a -> a[1]));
        Set<Integer> visited = new HashSet<>();
        Map<Integer, Integer> parent = new HashMap<>();
        
        pq.add(new int[]{start, 0});
        parent.put(start, null);
        
        while (!pq.isEmpty()) {
            int[] current = pq.poll();
            int node = current[0];
            
            if (node == goal) {
                return constructPath(parent, goal);
            }
            
            if (!visited.contains(node)) {
                visited.add(node);
                for (int[] neighbor : adjList.getOrDefault(node, new ArrayList<>())) {
                    if (!visited.contains(neighbor[0])) {
                        pq.add(neighbor);
                        parent.put(neighbor[0], node);
                    }
                }
            }
        }
        return Collections.emptyList();
    }

    private List<Integer> constructPath(Map<Integer, Integer> parent, int goal) {
        List<Integer> path = new ArrayList<>();
        for (Integer at = goal; at != null; at = parent.get(at)) {
            path.add(at);
        }
        Collections.reverse(path);
        return path;
    }
}

public class BestFirstSearchExample {
    public static void main(String[] args) {
        Graph graph = new Graph();
        graph.addEdge(1, 2, 2);
        graph.addEdge(1, 3, 1);
        graph.addEdge(2, 4, 3);
        graph.addEdge(3, 4, 1);
        graph.addEdge(4, 5, 5);

        int start = 1, goal = 5;
        List<Integer> path = graph.bestFirstSearch(start, goal);
        
        if (!path.isEmpty()) {
            System.out.println("Shortest path using Best First Search: " + path);
        } else {
            System.out.println("No path found.");
        }
    }
}
