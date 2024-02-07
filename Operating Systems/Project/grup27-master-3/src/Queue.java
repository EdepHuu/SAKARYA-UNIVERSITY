import java.util.ArrayList;
public class Queue {
    public ArrayList<Process> processes = new ArrayList<>();//Proseslerin tutulduğu ArrayList

    public ArrayList<Process> realtimequeue = new ArrayList<>();//Realtime proseslerin kuyruğr

    public ArrayList<Process> userqueue_one = new ArrayList<>();//1.User Kuyruğu

    public ArrayList<Process> userqueue_two = new ArrayList<>();//2.User Kuyruğu

    public ArrayList<Process> userqueue_three = new ArrayList<>();//3.User Kuyruğu

    //public int remaningMemory = 1024; // all memory

    public int remaningMemoryForRealTime = 64;  // remaning memory real times tasks

    public int remaningMemoryForUser = 960; // remaning memory for user's tasks

    public int remaningPrinter = 2; //Kalan printer sayısı

    public int remaningScanner = 1; //Kalan scanner sayısı

    public int remaningModem = 1;   //Kalan modem sayısı

    public int remaningCd = 2;  //Kalan cd sayısı

    public int control_id = -1;
    public int time = 0;
    public int print_time = 0;

    //Önceki Prosesin bilgilerini atar.
    public int prev_id;
    public int prev_remain_time;
    public int prev_priority;
    public String prev_color;
    public int control =0;

    //Süresi dolan proseslerin bilgilerini tutar.
    public int expired_id;
    public int expired_priority;
    public String expired_color;



    /**************--GET-SET FONKSİYONLARI--**************/

    //Bitme süresini döndürür.
    public int getExpired_time() {
        return expired_time;
    }

    //Bitme süresini atama yapar.
    public void setExpired_time(int expired_time) {
        this.expired_time = expired_time;
    }

    //Bitme süresini tutan değişken.
    public int expired_time;

    //Prosesleri döndürür.
    public ArrayList<Process> getProcesses() {
        return processes;
    }

    //Gelen listeyi Kuyruk sınıfının proses listesine atar.
    public void setProcesses(ArrayList<Process> processes) {
        this.processes = processes;
    }

    //Expired olan prosesin idsini döndürür.
    public int getExpired_id() {
        return expired_id;
    }

    //Expired prosesin idsini atama yapar.
    public void setExpired_id(int expired_id) {
        this.expired_id = expired_id;
    }

    //Expired olan prosesin önceliğini döndürür.
    public int getExpired_priority() {
        return expired_priority;
    }

    //Expired olan prosesin önceliğini atama yapar.
    public void setExpired_priority(int expired_priority) {
        this.expired_priority = expired_priority;
    }

    //Expired olan prosesin kalan süresini tutar.
    public int getExpired_remain_time() {
        return expired_remain_time;
    }

    //Expired olan prosesin kalan süresini atama yapar.
    public void setExpired_remain_time(int expired_remain_time) {
        this.expired_remain_time = expired_remain_time;
    }
    public void setExpired_color(String expired_color) {
        this.expired_color = expired_color;
    }

    public String getExpired_color() {
        return this.expired_color;
    }

    public int expired_remain_time;

    //Control değerini döndürür.
    public int getControl() {
        return control;
    }

    //Control değerine atama yapar.
    public void setControl(int control) {
        this.control = control;
    }

    //Önceki prosesin idsini döndürür
    public int getPrev_id() {
        return prev_id;
    }

    //Önceki prosesin idsine atama yapar.
    public void setPrev_id(int prev_id) {
        this.prev_id = prev_id;
    }

    //önceki prosesin kalan süresini tutar.
    public int getPrev_remain_time() {
        return prev_remain_time;
    }

    //önceki prosesin kalan süresini atama yapar.
    public void setPrev_remain_time(int prev_remain_time) {
        this.prev_remain_time = prev_remain_time;
    }

    //print time döndürür.
    public int getPrint_time() {
        return print_time;
    }
    //Print time ataması yapar.
    public void setPrint_time(int print_time) {
        this.print_time = print_time;
    }

    //Control idsini döndürür.
    public int getControl_id() {
        return control_id;
    }

    //Önceki prosesin önceliğini döndürür.
    public int getPrev_priority() {
        return prev_priority;
    }

    //Önceki prosesin önceliğini atama yapar.
    public void setPrev_priority(int prev_priority) {
        this.prev_priority = prev_priority;
    }

    //Control idsine atama yapar.
    public void setControl_id(int control_id) {
        this.control_id = control_id;
    }


    //time değerini döndürür.
    public void setPrev_color(String prev_color) {
        this.prev_color = prev_color;
    }

    public String getPrev_color() {
        return this.prev_color;
    }



    public int getTime() {
        return time;
    }
    //time değerini set eder.
    public void setTime(int time) {
        this.time = time;
    }

    /**************--GET-SET FONKSİYONLARI--**************/

    //Boş yapıcı fonksiyon
    public Queue(){}

    //Prosesler ArrayListine yeni proses ekler.
    public void AddProcessToJob(Process process){
        // log process

    	// if process is realtime and use memory more than 64, it will not be added to queue
        if(process.priority == 0 && process.memory_size > 64){
            ProcessLogger processLogger = new ProcessLogger(process, "HATA - Gerçek-zamanlı proses 64MB'tan daha fazla bellek talep ediyor proses silindi.");
            return;
        }

        // if process is realtime and use other resources, it will not be added to queue
        if (process.priority == 0 && (process.printer > 0 || process.scanner > 0 || process.modem > 0 || process.cd > 0)){
            ProcessLogger processLogger = new ProcessLogger(process, "HATA - Gerçek-zamanlı proses diğer kaynakları kullanamadığı için silindi.");
            return;
        }

        // if process is user and use more than 2 printer, 1 scanner, 1 modem, 2 cd, it will not be added to queue
        if(process.priority != 0 && (process.printer > 2 || process.scanner > 1 || process.modem > 1 || process.cd > 2)){
            ProcessLogger processLogger = new ProcessLogger(process, "HATA - Proses çok fazla kaynak talep ediyor proses silindi.");
            return;
        }

        // if process is user and use memory more than 960, it will not be added to queue
        if(process.priority != 0 && process.memory_size > 960){
            ProcessLogger processLogger = new ProcessLogger(process, "HATA - Kullanıcı prosesi 960MB'tan daha fazla bellek talep ediyor proses silindi.");
            return;
        }

        ProcessLogger processLogger = new ProcessLogger(process, null);
        this.processes.add(process);
    }

    public void SplitQueue(){

        for(int i=0;i<this.processes.size();i++){
            //Gelen prosesin önceliği 0 ise realtime kuyruğuna atar.
            if(this.processes.get(i).priority == 0){
                realtimequeue.add(this.processes.get(i));
            }
            else{
                //Gelen prosesin önceliği 1 ise 1.user kuyruğuna atar.
                if(this.processes.get(i).priority == 1){
                    this.userqueue_one.add(this.processes.get(i));
                }
                //Gelen prosesin önceliği 2 ise 2.user kuyruğuna atar.
                else if(this.processes.get(i).priority == 2){
                    this.userqueue_two.add(this.processes.get(i));
                }
                //Gelen prosesin önceliği 3 ise 3.user kuyruğuna atar.
                else if(this.processes.get(i).priority == 3){
                    this.userqueue_three.add(this.processes.get(i));
                }
            }
        }
    }
    
    

    //Prosesi çalıştırır.
    public void RunProcess(){
        int control = 0;
        //Real time kuyruğunu taramaya başlar.
        for(int i=0;i<this.realtimequeue.size();i++){

            //Control 0 ise ve prosesin ulaşma zamanı zamandan küçükse ve kalan zamanı 0dan büyükse ekrana yazdır.
            //prosesin kalan süresini 1 azalt.
            //Control değerini 1 yap.
            if(realtimequeue.get(i).arrival_time <= this.getTime() && this.realtimequeue.get(i).remain_time>0 && control==0 && this.realtimequeue.get(i).process_age<20 && (realtimequeue.get(i).arrival_time+20)>this.getTime()){
                // check if resources already allocated for this process
                if(realtimequeue.get(i).isResourcesAllocated()==false){
                    // check if there is a enough memory
                    if(remaningMemoryForRealTime >= realtimequeue.get(i).memory_size){
                        //if realtime process require other resources, it will be deleted from queue
                        if (realtimequeue.get(i).printer > 0 || realtimequeue.get(i).scanner > 0 || realtimequeue.get(i).modem > 0 || realtimequeue.get(i).cd > 0){
                            // delete process from queue
                            realtimequeue.remove(i);
                            System.out.println("Realtime process diğer kaynakları kullanamadığı için silindi."+""+"Process id: "+realtimequeue.get(i).id);
                        }
                        remaningMemoryForRealTime = remaningMemoryForRealTime - realtimequeue.get(i).memory_size;
                        realtimequeue.get(i).setResourcesAllocated(true);
                    }
                    else{
                        //System.out.println("Not enough memory for this process"+""+"Process id: "+realtimequeue.get(i).id+""+"process age: "+realtimequeue.get(i).process_age);
                        // even if process is not run properly, it should be aged
                        realtimequeue.get(i).process_age = realtimequeue.get(i).process_age + 1;
                        continue;
                    }
                }
                Color.setColor(this.realtimequeue.get(i).color);
                PrintProcess(this.realtimequeue.get(i));
                this.realtimequeue.get(i).remain_time = this.realtimequeue.get(i).remain_time -1;

                // age of process is increased
                this.realtimequeue.get(i).process_age = this.realtimequeue.get(i).process_age + 1;

                //if process is expired, release resources
                if(this.realtimequeue.get(i).process_age == 20){
                    remaningMemoryForRealTime = remaningMemoryForRealTime + realtimequeue.get(i).memory_size;
                    realtimequeue.get(i).setResourcesAllocated(false);
                }

                // if process is finished, release resources
                if(this.realtimequeue.get(i).remain_time == 0){
                    remaningMemoryForRealTime = remaningMemoryForRealTime + realtimequeue.get(i).memory_size;
                    realtimequeue.get(i).setResourcesAllocated(false);

                }
                control = 1;
            }
        }

        //Kontrol değişkeni 0 ise
        if(control==0){
            //1.user kuyruğunu tara
            for(int j=0;j<this.userqueue_one.size();j++){
                //Prosesin ulaşma zamanı zamandan küçükse ve kalan zamanı 0dan büyükse ekrana yazdır.

                //Control değerini 1 yap.
                if(userqueue_one.get(j).arrival_time <= this.getTime() && this.userqueue_one.get(j).remain_time>0 && control==0 && this.userqueue_one.get(j).process_age<20 && (userqueue_one.get(j).arrival_time+20)>this.getTime()){
                    // check if resources already allocated for this process
                    if(userqueue_one.get(j).isResourcesAllocated()==false){
                        // check if there is enough memory, printer, scanner, modem, cd even if 1 of them is not enough, process will not be run
                        if(remaningMemoryForUser >= userqueue_one.get(j).memory_size && remaningPrinter >= userqueue_one.get(j).printer && remaningScanner >= userqueue_one.get(j).scanner && remaningModem >= userqueue_one.get(j).modem && remaningCd >= userqueue_one.get(j).cd){
                            remaningMemoryForUser = remaningMemoryForUser - userqueue_one.get(j).memory_size;
                            remaningPrinter = remaningPrinter - userqueue_one.get(j).printer;
                            remaningScanner = remaningScanner - userqueue_one.get(j).scanner;
                            remaningModem = remaningModem - userqueue_one.get(j).modem;
                            remaningCd = remaningCd - userqueue_one.get(j).cd;
                            userqueue_one.get(j).setResourcesAllocated(true);
                        }
                        else{
                            //System.out.println("Not enough resources for this process"+""+" Process id: "+userqueue_one.get(j).id+""+" process priority"+userqueue_one.get(j).priority+""+" process age: "+userqueue_one.get(j).process_age);
                            // even if process is not run properly, it should be aged
                            userqueue_one.get(j).process_age = userqueue_one.get(j).process_age + 1;
                            continue;
                        }
                    }
                    Color.setColor(this.userqueue_one.get(j).color);
                    PrintProcess(this.userqueue_one.get(j));
                    //Tüm prosesleri günceller ve eğer öncelik değişmesi gerekiyorsa öncelik değiştirir.Süresini bir azaltır.
                    UpdateAllProcess(this.userqueue_one.get(j));
                    control = 1;
                }
            }
        }
        //Kontrol değişkeni 0 ise
        if(control == 0){
            //2.user kuyruğunu tara
            for(int k=0;k<this.userqueue_two.size();k++){
                //Prosesin ulaşma zamanı zamandan küçükse ve kalan zamanı 0dan büyükse ekrana yazdır.
                //Control değerini 1 yap.
                if(userqueue_two.get(k).arrival_time <= this.getTime() && this.userqueue_two.get(k).remain_time>0 && control==0&& this.userqueue_two.get(k).process_age<20 && (userqueue_two.get(k).arrival_time+20)>this.getTime()){
                    // check if resources already allocated for this process
                    if(userqueue_two.get(k).isResourcesAllocated()==false){
                        // check if there is enough memory, printer, scanner, modem, cd even if 1 of them is not enough, process will not be run
                        if(remaningMemoryForUser >= userqueue_two.get(k).memory_size && remaningPrinter >= userqueue_two.get(k).printer && remaningScanner >= userqueue_two.get(k).scanner && remaningModem >= userqueue_two.get(k).modem && remaningCd >= userqueue_two.get(k).cd){
                            remaningMemoryForUser = remaningMemoryForUser - userqueue_two.get(k).memory_size;
                            remaningPrinter = remaningPrinter - userqueue_two.get(k).printer;
                            remaningScanner = remaningScanner - userqueue_two.get(k).scanner;
                            remaningModem = remaningModem - userqueue_two.get(k).modem;
                            remaningCd = remaningCd - userqueue_two.get(k).cd;
                            userqueue_two.get(k).setResourcesAllocated(true);
                        }
                        else{
                            //System.out.println("Not enough resources for this process"+""+" Process id: "+userqueue_two.get(k).id+""+" process priority"+userqueue_two.get(k).priority+""+" process age: "+userqueue_two.get(k).process_age);
                            // even if process is not run properly, it should be aged
                            userqueue_two.get(k).process_age = userqueue_two.get(k).process_age + 1;
                            continue;
                        }
                    }
                    Color.setColor(this.userqueue_two.get(k).color);
                    PrintProcess(userqueue_two.get(k));
                    //Tüm prosesleri günceller ve eğer öncelik değişmesi gerekiyorsa öncelik değiştirir.Süresini bir azaltır.
                    UpdateAllProcess(this.userqueue_two.get(k));
                    control = 1;
                }
            }
        }
        //Kontrol değişkeni 0 ise
        if(control == 0){
            //3.user kuyruğunu tara
            for(int l=0;l<this.userqueue_three.size();l++){
                //Prosesin ulaşma zamanı zamandan küçükse ve kalan zamanı 0dan büyükse ekrana yazdır.
                //Control değerini 1 yap.
                if(userqueue_three.get(l).arrival_time <= this.getTime() && this.userqueue_three.get(l).remain_time>0 && control==0 && this.userqueue_three.get(l).process_age<20 && (userqueue_three.get(l).arrival_time+20)>this.getTime()){
                    // check if resources already allocated for this process
                    if(userqueue_three.get(l).isResourcesAllocated()==false){
                        // check if there is enough memory, printer, scanner, modem, cd even if 1 of them is not enough, process will not be run
                        if(remaningMemoryForUser >= userqueue_three.get(l).memory_size && remaningPrinter >= userqueue_three.get(l).printer && remaningScanner >= userqueue_three.get(l).scanner && remaningModem >= userqueue_three.get(l).modem && remaningCd >= userqueue_three.get(l).cd){
                            remaningMemoryForUser = remaningMemoryForUser - userqueue_three.get(l).memory_size;
                            remaningPrinter = remaningPrinter - userqueue_three.get(l).printer;
                            remaningScanner = remaningScanner - userqueue_three.get(l).scanner;
                            remaningModem = remaningModem - userqueue_three.get(l).modem;
                            remaningCd = remaningCd - userqueue_three.get(l).cd;
                            userqueue_three.get(l).setResourcesAllocated(true);
                        }
                        else{
                            //System.out.println("Not enough resources for this process"+""+" Process id: "+userqueue_three.get(l).id+""+" process priority"+userqueue_three.get(l).priority+""+" process age: "+userqueue_three.get(l).process_age);
                            // even if process is not run properly, it should be aged
                            userqueue_three.get(l).process_age = userqueue_three.get(l).process_age + 1;
                            continue;
                        }
                    }
                    Color.setColor(this.userqueue_three.get(l).color);
                    PrintProcess(this.userqueue_three.get(l));
                    //Tüm prosesleri günceller.Süresini bir azaltır.
                    UpdateAllProcess(this.userqueue_three.get(l));
                    control = 1;
                }
            }
        }
        setTime(getTime()+1);//şu anki zamanı 1 birim ileri götürür.
    }

    public void UpdateAllProcess(Process process){
        int control = 0;
        //Tüm prosesleri tarar.
        for(int i=0;i<this.processes.size();i++){
            //gelen prosesin idsi ve listedeki i prosesinin idsi eşitse
            if(this.processes.get(i).id == process.id && control ==0){
                //Önceliği 3 değilse önceliğini 1 arttır.3 ise 3de kalacak.
                if(process.priority!=3){
                    this.processes.get(i).priority = this.processes.get(i).priority+1;
                }
                //Kalan zamanı 1 azaltır.
                this.processes.get(i).remain_time = this.processes.get(i).remain_time -1;
                // control = 1; control before i edited
                // age of process is increased
                this.processes.get(i).process_age = this.processes.get(i).process_age + 1;

                //if process is expired, release resources
                if(this.processes.get(i).process_age == 20){
                    if(this.processes.get(i).priority == 0){
                        remaningMemoryForRealTime = remaningMemoryForRealTime + processes.get(i).memory_size;
                        processes.get(i).setResourcesAllocated(false);
                    }
                    else{
                        remaningMemoryForUser = remaningMemoryForUser + processes.get(i).memory_size;
                        remaningPrinter = remaningPrinter + processes.get(i).printer;
                        remaningScanner = remaningScanner + processes.get(i).scanner;
                        remaningModem = remaningModem + processes.get(i).modem;
                        remaningCd = remaningCd + processes.get(i).cd;
                        processes.get(i).setResourcesAllocated(false);
                    }
                }

                // if process is finished, release resources
                if(this.processes.get(i).remain_time == 0){
                    if(this.processes.get(i).priority == 0){
                        remaningMemoryForRealTime = remaningMemoryForRealTime + processes.get(i).memory_size;
                        processes.get(i).setResourcesAllocated(false);
                    }
                    else{
                        remaningMemoryForUser = remaningMemoryForUser + processes.get(i).memory_size;
                        remaningPrinter = remaningPrinter + processes.get(i).printer;
                        remaningScanner = remaningScanner + processes.get(i).scanner;
                        remaningModem = remaningModem + processes.get(i).modem;
                        remaningCd = remaningCd + processes.get(i).cd;
                        processes.get(i).setResourcesAllocated(false);
                    }
                }

                control = 1;
            }
        }
        //tüm kuyrukları temizler.
        this.userqueue_one.clear();
        this.userqueue_two.clear();
        this.userqueue_three.clear();
        this.realtimequeue.clear();
        //Tekrardan kuyruklara atama yapar.
        SplitQueue();
    }

    public void findAndDelete(int process_id,int process_priority){
        for(int i=0;i<this.processes.size();i++){
            if(this.processes.get(i).id==process_id){
                this.processes.remove(i);
            }
        }
    }

    public void PrintProcess(Process process){
        //Kontrol 0 ise print timea şu anki zamanı ata.
        if(getControl()==0){
            setPrint_time(getTime());
        }
        //Proses bilgilerini alır
        int id = process.id;
        int priority = process.priority;
        int remain_time = process.remain_time;
        String color = process.color;
        //end
        //is process expired?

        // Kesme var mı?
        if(this.prev_remain_time-1>0 && this.prev_id != id){
            Color.setColor(getPrev_color());
            System.out.println(getPrint_time()+" sn "+"proses askida (id:"+this.prev_id+" oncelik:"+(this.prev_priority+1)+" kalan sure:"+remain_time+")");
            //Expired proses olarak ata.

            //set expired process
            setExpired_color(this.prev_color);

            setExpired_id(this.prev_id);
            setExpired_priority(this.prev_priority+1);
            setExpired_remain_time(remain_time);
            setExpired_time(getPrint_time());
        }
        // Proses başladı mı?
        if(getControl_id()!= id){


            Color.setColor(process.color);
            System.out.println(getPrint_time()+" sn "+"proses basladi (id:"+id+" oncelik:"+priority+" kalan sure:"+remain_time+")");

            setPrint_time(getPrint_time()+1);
        }
        //Proses devam ediyor.
        if(getControl_id()==id){



            Color.setColor(process.color);
            System.out.println(getPrint_time()+" sn "+"proses yurutuluyor (id:"+id+" oncelik:"+priority+" kalan sure:"+remain_time+")");

            setPrint_time(getPrint_time()+1);
        }
        //Proses zaman aşımı
        if(getPrint_time()-getExpired_time()==21){
            Color.setColor(getExpired_color());
            System.out.println(getPrint_time()+" sn "+"proses zaman asimi (id:"+getExpired_id()+" oncelik:"+getExpired_priority()+" kalan sure:"+getExpired_remain_time()+")");

            findAndDelete(getExpired_id(),getExpired_priority());
        }
        //Proses bitti.
        if(remain_time-1 ==0){

            Color.setColor(process.color);
            System.out.println(getPrint_time()+" sn "+"proses sonlandi (id:"+id+" oncelik:"+priority+" kalan sure:"+(remain_time-1)+")" );


        }

        //Prosesi önceki proses yap.
        setPrev_id(id);
        setPrev_color(color);
        setPrev_remain_time(remain_time);
        setPrev_priority(priority);
        setControl_id(id);
        setControl(1);
    }

    //Böyle bir proses olup olmadığını tarar ve bool bir değer döndürür.
    public boolean isExist(int arrival_time,int priority){
        for(int i=0;i<this.realtimequeue.size();i++){
            if(this.realtimequeue.get(i).arrival_time<=arrival_time && this.realtimequeue.get(i).priority<priority){
                return true;
            }
        }
        return false;
    }

    //Kuyruğun uzunluğunu döndürür.
    public int QueueLength(){
        int length = 0;
        for(int i=0;i<this.processes.size();i++){
            length = length + this.processes.get(i).remain_time;
        }
        return length;
    }
    /*************--PROSES KUYRUKLARI FONSKİYONLARI--**************/

}
