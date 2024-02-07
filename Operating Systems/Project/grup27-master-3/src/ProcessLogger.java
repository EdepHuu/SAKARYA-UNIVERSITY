import java.util.ArrayList;

public class ProcessLogger {
    private static ArrayList<ProcessInfo> processes = new ArrayList<>();

    // Constructor to add a process to the processes ArrayList
    public ProcessLogger(Process process, String errorMessage) {
        ProcessInfo processInfo = new ProcessInfo(process, errorMessage);
        processes.add(processInfo);
    }

    // Example inner class to represent process information
    private static class ProcessInfo {
        private Process process;
        private boolean error;
        private String errorMessage;


        public ProcessInfo(Process process, String error) {
            this.process = process;
            if (error == null) {
                this.error = false;
            } else {
                this.error = true;
                this.errorMessage = error;
            }
        }
    }

    public static void printProcessTable() {
        System.out.println("Process Table:");
        System.out.println("ID\t\tArrival Time\t\tPriority\t\tPrinter\t\t  Scanner\t\t\t\tModem\t\t\tCD\t\t\tProcess State\t\tMemory Size");
        for (ProcessInfo processFromList : processes) {
            if (processFromList.error == true) {
                System.out.println(processFromList.process.getId() + "\t\t\t\t" +processFromList.errorMessage);}
            else
                System.out.println(processFromList.process.getId() + "\t\t\t\t" + processFromList.process.arrival_time + "\t\t\t\t" + processFromList.process.priority + processFromList.process.color + "\t\t\t\t" + processFromList.process.printer + "\t\t\t\t" + processFromList.process.scanner + "\t\t\t\t" + processFromList.process.modem + "\t\t\t\t" + processFromList.process.cd+ "\t\t\t\t" + processFromList.process.process_state+ "\t\t\t\t" + processFromList.process.memory_size);
            //System.out.println(processFromList.process.getId() + "\t\t\t\t" + processFromList.arrival_time + "\t\t\t\t" + processFromList.priority + processFromList.color + "\t\t\t\t" + processFromList.printer + "\t\t\t\t" + processFromList.scanner + "\t\t\t\t" + processFromList.modem + "\t\t\t\t" + processFromList.cd+ "\t\t\t\t" + processFromList.process_state+ "\t\t\t\t" + processFromList.memory_size);
        }
    }
    /*
    public static void printProcessTableAllData() {
        System.out.println("Process Table:");
        System.out.println("ID\t\tArrival Time\t\tPriority\t\tRemain Time\t\tPrinter\t\t\t\tScanner\t\t\t\tModem\t\tCD\t\t\t\tProcess State\t\t\t\tMemory Size");
        for (Process process : processes) {
            System.out.println(process.getId() + "\t\t\t\t" + process.arrival_time + "\t\t\t\t" + process.priority + "\t\t\t\t" + process.remain_time + "\t\t" + process.color + "\t\t\t\t" + process.printer + "\t\t\t\t" + process.scanner + "\t\t\t\t" + process.modem + "\t\t\t\t" + process.cd+ "\t\t\t\t" + process.process_state+ "\t\t\t\t" + process.memory_size);
        }
    }
    */
    // will be used to print the process table with the given process id
    public  static  void createErrorMessage(String message){
        //
    }
}
