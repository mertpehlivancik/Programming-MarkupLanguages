; multi-segment executable file template.

data segment
    ; add your data here!
    expression db "(((7+4)*3-2+9)+(7-3*5+4*(2+8+6*(5-3)))-(4*6-(2*8+4)+((6+5)+3*2+(9-1))-9))+((2-5+7*(2+5)*3-4)-9-(6*2+4*(2+4*7))+((2*9-(2*1)*0+4)+8-2*1))+((7*5)-4+(5*(6-5))+(2*4-2*1-4+2*3))+((2*3+7+9*2)+2*9-1*2+7*5+2)",0
    expressionN db 1000 DUP(?)    
    expressionD db 1000 DUP(?) 
    stringFail db "Statement is not balanced",0
    stringSuccess db "Statement is balanced",0
ends

stack segment
    dw   128  dup(0)
ends

code segment
start:
; set segment registers:
    mov ax, data
    mov ds, ax
    mov es, ax 
    ; add your code here 
StartBalanced:    
    lea si,expression
balanced:
    cmp [si],0
    je Success   
    cmp [si],"("    ;Bu kisimda acik ve kapali parantezler kontrol ediliyor.Eger acik
    je stackEkle    ;parantez varsa stackEkle labelina atlanarak stack'e ekleme yapiliyor
    cmp [si],")"    ;Eger kapali parantez varsa stackCikar label'i ile stack'ten acik 
    je stackCikar   ;parantez siliniyor.Buradaki ekleme ve cikarma yapmamizdaki temel
    add si,1        ;amacimiz expression'un balance olup olmadigini kontrol etmektir.
    jmp balanced    ;Bu islemin sonucunda stack bos ise expression balance'dir.  
stackEkle:
    push [si]
    add si,1
    jmp balanced 
stackCikar:
    pop bx
    cmp bl,'('
    jne notSuccess
    add si,1
    jmp balanced
notSuccess:
    lea di,stringFail 
    notSuccessLoop:
    cmp [di],0
    je exit        
    mov dl, [di]
    mov ah, 2h     
    int 21h        ; output string at ds:dx  
    add di,1        
    jmp notSuccessLoop          
Success: 
    pop bx
    cmp bl,'('
    je notSuccess
    lea di,stringSuccess
    push bx 
    SuccessLoop:
    cmp [di],0
    je StartInfixToPostfix        
    mov dl, [di]
    mov ah, 2h     
    int 21h        ; output string at ds:dx  
    add di,1        
    jmp SuccessLoop     
    
StartInfixToPostfix: ; Bu kisimda expression infix form'dan postfix form'a donusturulup
    sub si,si        ; expressionN isimli array'e donusumun sonucu atanir.
    sub di,di
    sub ax,ax        ; Burada 69 ve 76. satirlar arasinda register'larin degerleri sifirlanir.
    sub bx,bx
    sub cx,cx
    sub dx,dx     
    lea si,expression
    lea di,expressionN
infToPostf:
    mov bx,[si]
    cmp bl,0            ; expression'un sonuna geldiginde finalInfToPost label'ina atlanilir.
    je finalInfToPost 
    cmp bl,'*'           ; Buralarda temel amacimiz gelen operation'lari tespit edip
    je multiplication    ; gerekli islemleri yapmaktir. Ornegin 5+3+2 islemini infix'ten
    cmp bl,'+'           ; postfix'e donusturelim. Ilk olarak 5 operation olmadigindan 
    je addition          ; ekrana basilir.Sonra '+' sembolu geldiginde stack bos mu diye
    cmp bl,'-'           ; kontrol edilir.Eger bos ise direk push'lanir ve diger step de  
    je substraction      ; ekrana 3 basilir.Simdi tekrardan '+' sembolu geldi.Stack'in 
    cmp bl,'('           ; son elemani pop'lanir ve gelen eleman ile stack'in son elemaninin
    je parAc             ; (Operation) islem onceligine gore kiyasi yapilir.Bu durum icin 
    cmp bl,')'           ; '+''nin '+''ya ustunlugu olmadigindan son gelen '+''yi push 
    je parKap            ; edebilmek icin stack'in icindeki '+' ekrana bastirilir ve 
                         ; gelen arti stack'e atilir.Eger gelen operation bu durum icin
    mov dl, [si]         ; '*' olsaydi '*' nin '+'ya gore ustunlugu oldugundan '*' direk  
    mov ah, 2h           ; push'lanacakti.En son olarak 2 ekrana basilir ve stack'in 
    int 21h              ; icinde ne varsa output ekranina bastirilir.Print yapilan her yerde 
    mov [di],dl          ; expressionN arrayine eleman ekledim.
    add di,1             ; output string at ds:dx
    
    add si,1
    jmp infToPostf 

substraction:
    pop cx                   ; Burada pop yapmamizin temel amaci stack'in icinde ne oldugunu
    cmp cl,'*'               ; kontrol edip ona gore islemlerimize karar vermektir.
    je substractionMult
    cmp cl,'+'
    je substractionAdd
    cmp cl,'-'
    je substractionSub
    cmp sp,0102H             ; Stack bos iken pop'larsam sp = 0102H olur.(normalde sp = 0100H)  
    je substractionStackAdd  ; o zaman bir kere pop yaptigimda stack eger bos ise sp=0102H olur
    cmp cl,'('               ; ve islemlerimizi ona gore yapariz.
    je substractionStackAdd
substractionAdd:
    mov dl,cl    
    mov ah, 2h     
    int 21h        ; output string at ds:dx  
    mov [di],dl
    add di,1
    jmp substraction 
substractionSub:
    mov dl,cl    
    mov ah, 2h     
    int 21h        ; output string at ds:dx 
    mov [di],dl
    add di,1
    jmp substraction   
substractionMult:
    mov dl,cl
    mov ah, 2h     
    int 21h        ; output string at ds:dx
    mov [di],dl
    add di,1 
    jmp substraction    
substractionStackAdd:
    push cx          ;ilk yapilan push stack'in baslangic karakterini yerine yazmak icin yapilirken
    push bx          ;ikincisi okunan karakteri stack'e atar.
    add si,1         ;Geriye kalan butun infToPostf islemlerinde isleyis benzerdir.
    jmp infToPostf   

addition:
    pop cx
    cmp cl,'*'
    je additionMult
    cmp cl,'+'
    je additionAdd
    cmp cl,'-'
    je additionSub
    cmp sp,0102H 
    je additionStackAdd  
    cmp cl,'('
    je additionStackAdd
    
additionAdd:
    mov dl,cl    
    mov ah, 2h     
    int 21h        ; output string at ds:dx
    mov [di],dl
    add di,1 
    jmp addition 
additionSub:
    mov dl,cl    
    mov ah, 2h     
    int 21h        ; output string at ds:dx
    mov [di],dl
    add di,1 
    jmp addition   
additionMult:
    mov dl,cl
    mov ah, 2h     
    int 21h        ; output string at ds:dx 
    mov [di],dl
    add di,1
    jmp addition    
additionStackAdd:
    push cx
    push bx
    add si,1
    jmp infToPostf     

   
multiplication: 
    pop cx 
    cmp sp,0102H 
    je multiplicationStackAdd
    cmp cl,'*'
    je multiplicationMult 
    cmp cl,'+'
    je multiplicationStackAdd 
    cmp cl,'-'
    je multiplicationStackAdd
    cmp cl,'('
    je multiplicationStackAdd
    jmp multiplication
multiplicationStackAdd:
    push cx
    push bx
    add si,1
    jmp infToPostf
multiplicationMult:
    mov dl,cl
    mov ah, 2h     
    int 21h        ; output string at ds:dx
    mov [di],dl
    add di,1 
    jmp multiplication  
    
parAc: 
    push bx
    add si,1       
    jmp infToPostf     
        
parKap:
    pop cx
    cmp cl,'('
    je parKapAcik
    cmp cl,'*'
    je parKapAddOutput 
    cmp cl,'+'
    je parKapAddOutput
    cmp cl,'-'  
    je parKapAddOutput   
    parKapAcik:    
    add si,1
    jmp infToPostf     
    parKapAddOutput:
    mov dl,cl
    mov ah, 2h ; output string at ds:dx
    mov [di],dl
    add di,1    
    int 21h 
    jmp parKap 

finalInfToPost:
    pop cx 
    cmp sp,0102H 
    je StartAsciiConvertToDecimal  ; burada yapilan dongu sayesinde expression'un 
    mov dl,cl                      ; elemanlari bittikten sonra stack'te en son kalan 
    mov ah, 2h                     ; operationlar'i output ekranina bastirilarak stack
    int 21h                        ; eski haline getirilir.
    mov [di], dl
    jmp finalInfToPost 
    
StartAsciiConvertToDecimal:
    mov [di+1],'$'            ; Postfix olarak yazilan expression'un sonucunu bulmak 
    push cx                   ; icin expressionN arrayinin icindeki sayilari ascii'den decimal'e cevirmemiz
    sub si,si                 ; gereklidir.StartAsciiConvertToDecimal label'indan itibaren
    sub di,di                 ; StartPostfixOperations label'ina kadar bu islemler
    sub ax,ax                 ; gercekletirilir ve sonuclar expressionD'ye atilir.  
    sub bx,bx                 ; mov [di+1],'$' in amaci expressionN'in sonuna bitis karakteri 
    sub cx,cx                 ; olarak '$' koymaktir.Cunku bitis karakterini bilmeden dongu kurup
    sub dx,dx                 ; cevirme yapamayiz.
    lea si,expressionN
    lea di,expressionD
asciiConvertToDecimal:
    mov bl,[si]           
    cmp bl,0
    je StartPostfixOperations
    cmp bl,'+'
    je asciiConvertToDecimalAdd   ; Operationlar direk olarak ascii seklinde array'e
    cmp bl,'-'                    ; eklenir.
    je asciiConvertToDecimalSub 
    cmp bl,'*'
    je asciiConvertToDecimalMult 
    cmp bl,'$'
    je asciiConvertToDecimalDolar
    and bl,0Fh                    ;Burada ascii deger decimal'e cevriliyor.
    mov [di],bl
    add si,1
    add di,1
    jmp asciiConvertToDecimal            
               
asciiConvertToDecimalAdd:
    mov [di],bl
    add si,1
    add di,1
    jmp asciiConvertToDecimal            
    
asciiConvertToDecimalSub:           
    mov [di],bl
    add si,1
    add di,1
    jmp asciiConvertToDecimal           
    
asciiConvertToDecimalMult:           
    mov [di],bl
    add si,1
    add di,1
    jmp asciiConvertToDecimal

asciiConvertToDecimalDolar:
    add si,1
    jmp asciiConvertToDecimal 

StartPostfixOperations:  ; expression'un sonucu burada hesaplanir.
    mov [di],'$'         ; expressionD'nin sonuna bitis karakteri eklenir.
    sub si,si
    sub di,di
    sub ax,ax
    sub bx,bx
    sub cx,cx
    sub dx,dx    
    lea si,expressionD
postfixOperations:
    mov bl,[si]
    cmp bl,'$'
    je exit
    cmp bl,'+'
    je postfixOperationsAdding 
    cmp bl,'-'
    je postfixOperationsSubstracting
    cmp bl,'*'
    je postfixOperationsMultiplication 
    push bx 
    add si,1
    jmp postfixOperations        
    
postfixOperationsAdding:
     sub ax,ax
     sub dx,dx
     pop ax
     pop dx 
     add dl,al
     push dx 
     add si,1
     jmp postfixOperations      
               
postfixOperationsSubstracting:
     sub ax,ax
     sub dx,dx
     pop ax
     pop dx 
     sub dl,al
     push dx 
     add si,1
     jmp postfixOperations           
    
postfixOperationsMultiplication:
     sub ax,ax
     sub dx,dx
     pop ax
     pop dx
     mul dl
     push ax 
     add si,1
     jmp postfixOperations 
    ; wait for any key....    
    mov ah, 1
    int 21h
    exit:
    sub si,si
    sub di,di
    sub ax,ax
    sub bx,bx
    sub cx,cx
    sub dx,dx 
    pop dx   ; islemin sonucunu dx register'inda gorebilirsiniz.
    mov ax, 4c00h ; exit to operating system.
    int 21h    
ends

end start ; set entry point and stop the assembler.
          ;sub 48h