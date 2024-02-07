import java.util.Random;
public class Process {
    public int id = 0;
    public int arrival_time;
    public int priority;
    public int remain_time;
    public String color ;

    public String process_state = "waiting"; // waiting,ready, running, blocked, finished
    public boolean isResourcesAllocated = false;
    public int process_age = 0;  // 20 saniye dolduğu zaman process'in sonlandırılması için kullanılacak.

    public int memory_size; // how many Mbyte will be used by process
    public int printer ; // how many printer will be used by process
    public int scanner ; // how many scanner will be used by process
    public int modem ; // how many modem will be used by process
    public int cd ; // how many cd will be used by process

    public void setResourcesAllocated(boolean resourcesAllocated) {
        isResourcesAllocated = resourcesAllocated;
    }

    public boolean isResourcesAllocated() {
        return isResourcesAllocated;
    }


    public Queue jobDispatchList = new Queue();

    //yap�c� fonksiyona parametreler atanarak proses �zellikleri tan�mlan�r.
    public Process(int _id,int _arrival_time,int _priority,int _remain_time,String color, int _memory_size, int _printer, int _scanner, int _modem, int _cd){
        this.id = _id;
        this.arrival_time = _arrival_time;
        this.priority = _priority;
        this.remain_time = _remain_time;
        this.color = color;
        this.memory_size = _memory_size;
        this.printer = _printer;
        this.scanner = _scanner;
        this.modem = _modem;
        this.cd = _cd;
    }
    //bo� yap�c� fonksiyon
    public Process(){}

    //Get-Set id metodlar�.
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }

    public int getProcessAge() {
        return process_age;
    }

    public void increaseProcessAge() {
        this.process_age++;
    }

    public Process CreateNewProcess(String line){
        //14 farkl� renkten random de�er al�p prosese gelen random say�daki renk atan�r.
        Random rand = new Random();
        String color = Color.getRandomColor();
        int arrival_time;
        int priority;
        int time_process;

        String split_line[] = line.split(",");// virg�l karakteri ile ay�r�r.
        arrival_time = Integer.parseInt(split_line[0]);//ilk de�er var�� s�resi
        String priority_string = split_line[1].substring(1,2);
        priority = Integer.parseInt(priority_string);//dizinin 1. indisi �ncelik
        String time_process_string = split_line[2].substring(1,2);
        time_process = Integer.parseInt(time_process_string);//dizinin 2. indisi �ncelik
        String memory_size_string = split_line[3].substring(1);
        int memory_size = Integer.parseInt(memory_size_string);//dizinin 3. indisi memory_size
        String printer_string = split_line[4].substring(1,2);
        int printer = Integer.parseInt(printer_string);//dizinin 4. indisi printer
        String scanner_string = split_line[5].substring(1,2);
        int scanner = Integer.parseInt(scanner_string);//dizinin 5. indisi scanner
        String modem_string = split_line[6].substring(1,2);
        int modem = Integer.parseInt(modem_string);//dizinin 6. indisi modem
        String cd_string = split_line[7].substring(1,2);
        int cd = Integer.parseInt(cd_string);//dizinin 7. indisi cd

        Process new_process = new Process(this.id,arrival_time,priority,time_process,color,memory_size,printer,scanner,modem,cd);//gelen de�erlerle proje olu�turulur.
        setId(this.id +1);//id atan�r ve sonraki proses i�in 1 artar.
        return new_process;
    }
}
