public class Memory {

    private int maxMemoryForUsersTasks = 960;
    private int maxMemoryForRealtimeTasks = 64;

    // maxMemoryForUsersTasks için get fonksiyonu
    public int getMaxMemoryForUsersTasks() {
        return maxMemoryForUsersTasks;
    }

    // maxMemoryForRealtimeTasks için get fonksiyonu
    public int getMaxMemoryForRealtimeTasks() {
        return maxMemoryForRealtimeTasks;
    }
    public int memory_sizeForRealTimeTasks=64;
    public static int memory_sizeForUserTasks=960;
    private int process_id;
    private boolean isAlreadyAllocated=false;

    public Memory(int process_id){
        this.process_id=process_id;
    }

    public int getMemory_sizeForRealTimeTasks() {
        return memory_sizeForRealTimeTasks;
    }


    public void allocateMemoryForRealTimeTasks(int memory_sizeForRealTimeTasks) {
        this.memory_sizeForRealTimeTasks -= memory_sizeForRealTimeTasks;
    }

    public void releaseMemoryForRealTimeTasks(int memory_sizeForRealTimeTasks) {
        this.memory_sizeForRealTimeTasks += memory_sizeForRealTimeTasks;
    }

    public int getMemory_sizeForUserTasks() {
        return memory_sizeForUserTasks;
    }

    public void allocateMemoryForUserTasks(int memory_sizeForUserTasks) {
        this.memory_sizeForUserTasks -= memory_sizeForUserTasks;
    }

    public void releaseMemoryForUserTasks(int memory_sizeForUserTasks) {
        this.memory_sizeForUserTasks += memory_sizeForUserTasks;
    }

    public int getProcess_id() {
        return process_id;
    }


}

