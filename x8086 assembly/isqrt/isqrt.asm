; multi-segment executable file template.
#start=simple.exe#
#make_bin#
name "simple"                                                                           ;ReadMe
data segment
    ; add your data here!                             ; Bu program input porttan(Port 110) aldigi degerin karekokunu alarak
    ;pkey db "press any key...$"                      ; output portta(Port 112) gonderir. Ilk olarak main'de kullanilicak 
ends                                                  ; registirlarin initilization'unun ardindan output portunun(112) degeri 
stack segment                                         ; sifirlanmistir. 
    dw   128  dup(0)
ends                                                  ; ilk olarak "SayininUstunundekiLogaritma,IkininKatiOlmayanSayi,SayininustunuBulanBolme,
code segment                                          ; UstAlmaIslemiXBulma" labellari "x=2^[log2(n)]/2" denklemimin sonucunda x'in degerini
start:                                                ; bulmak için calisir. Ben cozume  logaritma hesabindan basladim.
; set segment registers:                              ; "log2(n)" in sonucuna z diyelim(ben bunu programlarken gecici olarak bir register
    mov ax, data                                      ; kullaniyorum)."log2(n)=z" = "2^z=n" olduguna gore ve n'i(inputtan gelen deger) de 
    mov ds, ax                                        ; bildigime gore buradan z'yi bulursam eger logaritmanin sonucunu hesaplamis olurum.
    mov es, ax                                        ; Iste bu noktada bir problemle karsilasiyoruz.Eger verilen input(n) ikinin kati
    ; add your code here                              ; olmazsa o zaman yaklasik olarak gercek degere en yakin z degerini hesaplamamiz 
main:                                                 ; gerekecektir.Iste bunu "IkininKatiOlmayanSayi" labelinde gerceklestiriyorum.
   sub ax,ax                                          ; Bu islemi sayisal bir ornekle aciklamak daha iyi olacaktir.
   sub bx,bx                                          ;
   sub cx,cx                                          ; Ornegin n=27 oldugunda "SayininUstunundekiLogaritma" labelinda 2'den baslanilarak
   sub dx,dx                                          ; 27?=2 degilse 27?=4 seklinde 2'in kuvvetleri 27'ye esit mi degil mi kontrol edilir.
   mov ax,0000h                                       ; Eger 2'nin kuvveti 27'yi gecti ise(ornegin 32 oldugunda) "IkininKatiOlmayanSayi" 
   out 112, ax                                        ; labelina gecilir.Burada gercek degere en yakin z degerinin bulunmasi amaciyla
   mov ax,0                                           ; "32-27" ve "27-16" sonuclari karsilastirilir.Eger buradaki gibi "32-27" daha 
   in al,110                                          ; kucuk cikarsa counter(z) 5 olarak kalir ama burada 27 yerine 17 olsaydi "17-16" 
   mov dl,al                                          ; sonuncu bir olacagi icin counter(z)'i 5 olarak birakmak anlamsiz olacaginda
                                                      ; z(counter) = 5-1 = 4 olacakti.
Isqrt:          
    mov di,0                                          ; Logaritmanin sonucu bulundukta sonra cikan sonucu 2'ye bolmemiz gerekcektir.
    mov bx,1                                          ; 2'ye bolme islemini shifter kullanarak yapiyoruz.Eger bir sayiyi bir kere saga
    mov al,2                                          ; shift edersek 2'ye bolmus oluruz.
    mov bh,2                                          ;                             1 kere saga shift
SayininUstunundekiLogaritma:                          ;          Ornegin; 4 = 0010 -------------------> 0001 = 2 
    mov cl,al                                         ;
    cmp dx,cx                                         ;      Yukaridaki islemler "SayininustunuBulanBolme" labelinde gerceklesir.
    je SayininustunuBulanBolme                        
    cmp dx,cx                                         ; Sayinin ustunu de buldugumuza gore bulunan uste gore 2'nin kuvvetini alip 
    jl IkininKatiOlmayanSayi                          ; x'i bulabiliriz.Bu islemler "UstAlmaIslemiXBulma" labelinde gerceklesir.
    mul bh                                            
    add bx,1                                          ; y = [(x+[n/x])/2] denkleminin sonucu "yBulma,nBoluX,nBoluXcik" labellerinda
    jmp SayininUstunundekiLogaritma                   ; bulunmustur. Burada [n/x] div komutu kullanilmadan cikarma yaparak
IkininKatiOlmayanSayi:                                ; bulunmustur.2'ye bolme islemi yukaridaki gibi bir bit saga shift edilerek
    mov ah,dl                                         ; yapilmistir.
    mov ch,cl                                         
    sub ch,ah                                         ; while(y<x){
    shr cl,1                                          ;
    sub ah,cl                                         ;       x = y
    cmp ah,ch                                         ;       y = [(x + [n/x])/2]
    jg SayininustunuBulanBolme                        ;                   
    sub bx,1                                          ;     }
    jmp SayininustunuBulanBolme                       ;     return x
                                                      ;
SayininustunuBulanBolme:                              ;   Islemlerinin sonucu "while,whileNboluX,whileNboluXcik,return"
    sub bh,bh                                         ;   labellerinda bulunmus ve return labelinde sonuc output portuna(112) 
    sub cx,cx                                         ;   gonderilip islem tamamlanmistir.
    mov cx,bx
    shr cx,1                                          ;; COMP 326 - Introduction to Microprocessors (Dr. Hüseyin Hisil)
    mov bx,cx                                         ;; HM3-Isqrt April 30,2018 ----- May 6,2018
    mov al,2                                          ;; Mert PEHLIVANCIK
    mov cl,2                                          ;; 16070001104
UstAlmaIslemiXBulma:                                  ;; Computer Engineering 
    cmp bx,1                                            
    je yBulma                                          
    mul cl
    sub bx,1
    jmp UstAlmaIslemiXBulma

yBulma:    
    mov bl,al 
    sub ax,ax 
    sub cx,cx 
    mov ch,dl 
    mov cl,bl 
nBoluX:   
    cmp ch,cl
    jle nBoluXcik:
    sub ch,cl 
    add al,1
    jmp nBoluX
nBoluXcik: 
    mov ch,al    
    add ch,cl  
    mov cl,ch 
    mov ch,0
    shr cx,1
    mov di,cx 

while: 
    mov ax,dx 
    cmp cx,bx  
    jge return  
    mov bx,cx  
whileNboluX:
    cmp ax,bx
    jle whileNboluXcik 
    sub ax,bx
    add si,1
    jmp whileNboluX
whileNboluXcik:
    mov ax,si
    add ax,bx    
    mov cx,ax
    shr cx,1
    jmp while  
return:
    mov ax,cx
    out 112,ax   
hlt  
    ; wait for any key....    
    mov ah, 1
    int 21h
    exit:
    mov ax, 4c00h ; exit to operating system.
    int 21h    
ends

end start ; set entry point and stop the assembler.