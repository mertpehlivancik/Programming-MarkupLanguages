org 100h
.data
msg db 'jgzgfyzxaizaxkyfzngzfngbkfboyohorozefuazyojkfznkfyotmrkfznxkgjkjfktboxutsktzfznkefgxkfixkgzkjfgtjfj',  
msgtwo db 'kyzxuekjfotfynuarjfgrcgeyfngbkfxklkxktikfiuatzyfotfznkfqkxtkrfmgxhgmkfiurrkizoutfjukyftuzfkdoyzfgtj', 
msgthree db 'fuazyojkfznkfqkxtkrfmgxhgmkfiurrkizoutfoyfyrucfgtjfotklloioktzfcnoinfskgtyfzngzfeuafghyurazkrefngbk', 
msgfour db 'fzufxklkxktikfiuatzfgrrfeuaxfaykyfxklkxktikfiuatzotmfskgtyfzngzfeuafigtfgbuojfruiqotmfgtjfgrrucyfsa', 
msgfive db 'rzovrkfaykxyfzufngbkfgiikyyfzufznkfjgzgfyzxaizaxkfotfvgxgrrkrfgtjftuzfngbotmfzufcuxxefghuazfznkfyzx', 
msgsix db 'aizaxkfyajjktrefmuotmfgcgeflxusfatjkxfznksfpayzfhkigaykfznkefyrkvzfuxfjojfyuskznotmfkrykfluxfgfcnor', 
msgseven db 'kftuzkfzngzfruiqotmfoyftuzfgfxkvrgiksktzfluxfxklkxktikfiuatzotmfruiqotmfoyfaykjfzufqkkvfjgzgfyzxaiz', 
msgeight db 'axkyfiunkxktzfcnorkfxklkxktikfiuatzotmfoyfgfsksuxefsgtgmksktzfzkintowakfayagrrefhuznfgxkftkkjkjfgtj', 
msgnine db 'fznkefgxkftuzfzufhkfiutlaykjfcoznfkginfuznkxfsgteefjgzgfyzxaizaxkyfigtfotjkkjfngbkfzcufrkbkryfulfxk',  
msgten db 'lkxktikfiuatzotmfcnktfznkxkfgxkfaykxyfulfjollkxktzfirgyykyfznkfyahirgyyfiuatzfiuatzyfznkftashkxfulf',
msgeleven db 'yahirgyyfaykxyfgtjfjkixksktzyfznkfmruhgrfiuatzfpayzfutikfcnktfznkfyahirgyyfiuatzfmukyfzufkxufkddgsv',  
msgtwelve db 'rkyfulfznoyfqotjfulfsarzofrkbkrfxklkxktikfiuatzotmfigtfhkfluatjfotfsksuxefssgtgmksktzfgtjfotflorkye', 
msgthirteen db 'yzksfiujkfxkskshkxfolfgtuznkxfznxkgjfigtflotjfeuaxfjgzgfyzxaizaxkfgtjfeuafjuftuzfngbkfgfxklkxktikfi', 
msgfourteen db 'uatzfutfozfeuafgrsuyzfikxzgotrefngbkfgfham', 0
givingAlphabet db 'qjxpkwvbgyfmdhlicursoante ',0 
sortedAlphabet db 'abcdefghijklmnopqrstuvwxyz',0 
sortedFrequency dw 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.code ;Yukaridaki sifreli texti 14 parcaya bolmemin sebebi variables bolumunde metnin tam olarak gorulmesini saglamaktir(Variables bolumunde bir labelda maksimum 99 karakter gosterilir.         
main proc
CalculatingFrequency: ;Frekans hesaplama 21-42(Line Number)arasindadir.             
    lea bx,msg  ;msg'nin ilk elemaninin adresi bx register'ina atanmistir.
    lea di,sortedAlphabet ;sortedAlphabet'in ilk elemanin adresi di registerina atanmistir.
    lea si,sortedFrequency ;sortedFrequency'in ilk adresi si registerina atanmistir.
startingCalculating:            ;  
    mov ah,[bx]                 ;  
    mov al,[di]                 ; startingCalculating(25-34) labelinda amacim mesajin
    cmp ah,al                   ; elemanlarini(orn:ilk eleman j) sortedAlphabet'de(a'dan z'ye sirali) bulmak
    je increaseFrequency        ; ve bulunan karakterin index'i kadar sortedFrequency'in index'ini arttirmaktir.
    add di,1                    ; Boylece a'dan z'ye sirali bir bicimde frekanslar bulunmus olacaktir
    add si,2                    ;
    jmp startingCalculating     ;
increaseFrequency:
    add [si],1                  ;Bu kisimda ise bulunan index'deki degeri 1 arttirarak karakter 
    add bx,1                    ;sayimi yapilir.Sonuc olarak bu islem bittiginde a'dan z'ye 
    lea di,sortedAlphabet       ;butun karakterlerin frekansi bulunmus olur.
    lea si,sortedFrequency
    mov dl,[bx]   
    cmp dl,0
    jne startingCalculating 
CharsAndTheirFrequencyBubbleSort:
mov ax,0
mov bx,0 
mov dx,0                           ;42-48 arasinda initializations islemi gerçeklesmistir.  
mov di,0
mov si,0
lea bx,sortedFrequency 
lea si,sortedAlphabet 
length:
     mov ax,[bx]                   ; CharsAndTheirFrequencyBubbleSort ile ChangeOfLocationOfChar arasinda bubble sort
     add bx,2                      ; islemi yapilmaktadir.Kodun bu kismina gecildiginde sirali bir sekilde karakterler ve
     cmp ax,0                      ; onlara ait frekanslar elimizde mevcuttur.Fakat frekanslar kucukten buyuge veya alfabedeki
     je reset                      ; karakterler az kullanilandan cok kullanilana gore sirali degildir.Bu sebeple frekanslar 
     add di,1                      ; arasinda kucukten buyuge siralama yaptim ve yaptigim her degisikligi alfabeye de yansittim.
     jmp length                    ; Boylece elimde metinde az kullanilandan cok kullanilana dogru giden bir karakter dizisi                             
reset:                             ; oldu.Ornegin siralama sonuncunda elimde asagidaki gibi iki karakter dizisi olacak:
     lea bx,sortedFrequency        ;
     sub di,1                      ;  sortedAlphabet 'w','p','d','v','q' ...
     mov dx,0                      ; sortedFrequency  1   2   3   6   7  ...
     mov bp,0                      ;
     jmp comp                      ;  Yukaridaki karakter dizisinden anlasilacagi uzere w'dan sifreli metinde 1 tane kullanilmistir.
arakat:                            ;  O zaman bize verilen grafige gore sifresi cozulmus metinde hangi karakterden 1 tane 
     add bp,1                      ;  varsa veya en az kullanilan karakter hangisi ise w'un karsiligi olarak o karakterin gelmesi muhtemeldir. 
     cmp bp,di
     je ChangeOfLocationOfChar 
     lea bx,sortedFrequency 
     lea si,sortedAlphabet
     mov dx,0
     jmp comp
plus:
add si,1
jmp comp    
comp:                               ;comp labelinda siralama islemi gerçeklestirilmektedir.
     cmp dx,di
     je arakat
     add dx,1    
     mov ax,[bx]                    ;
     mov cx,[bx+2]                  ;Okunan frekanslar registerlara yazilir
     add bx,2                       ;
     cmp ax,cx                      ;Registerlar arasi karsilastirma yapilir.Eger ax>cx ise ax ve cx in degerleri degistirilip array'e yazilmaz 
     jl plus                        ;ve kosul saglanana kadar veya arrayin sonuna kadar arrayin index'i ötelenip elemanlari karsilastirilir.Ama
     sub bx,2                       ;buradaki önemli nokta sortedFrequency'de yapilan her öteleme ve degisiklik sortedAlphabet'e de yansitilmalidir. 
     mov [bx],cx                    ;Burada ax<cx oldugunda plus labelina sicramasinin temel sebebi budur.sortedFrequency'in indexi 80. satirda  
     mov [bx+2],ax                  ;artarken sortedAlphabet'in index'i plus labelinda artar ve yeniden karsilastirma yapilir.
     mov ah,[si]
     mov al,[si+1]     
     mov [si],al
     mov [si+1],ah     
     add si,1     
     add bx,2
     jmp comp 
ChangeOfLocationOfChar:             ;92. ve 121. satirlar arasi sifreli metindeki karakterlerin degistirilmesi islemi yapilmaktadir.
mov ax,0                            ;93-99 arasinda initializations islemi gerceklesmistir.
mov bx,0                            ;Karakter degistirme kodunu bir ornek uzerinden anlatmak istiyorum.Ornegin metnin ilk karakteri olan j'nin 
mov dx,0                            ;degisimini basamak basamak inceleyelim.Ilk olarak metnin ilk elemaninin adresini,yukarida bubble sort yaptigimiz
mov di,0                            ;sortedAlphabet'in ilk elemaninin adresini ve bize sifreyi cozmemiz icin verilen grafikteki karakterlerin bulundugu  
mov si,0                            ;array olan givingAlphabet'in ilk elemaninin adresini registerlara atadik.GivingAlphabet de az kullanilan karakterlerden
lea bx,msg                          ;cok kullanilana dogru siralanistir.
lea di,sortedAlphabet               ;93. ve 102. satir aralarinda bu islemler gerceklesmistir.
lea si,givingAlphabet
change:                             ;101 ve 110. satirlar arasinda msg'deki eleman sortedAlphabet'de aranmis ve givingAlphabet'in index'i sortedAlphabet'in 
mov ah,[di]                         ;index'i ile paralel olarak arttirilmistir.Karakter bulundugunda degistir label'ina gecilir.
mov dl,[bx]
cmp dl,ah
je degistir
add di,1 
add si,1
jmp change
degistir:                           ;suanda ilk eleman olan j'i sortedAlphabet'de buldum ve yukarida givingAlphabet'in de index'ini es zamanli olarak arttirdigim
mov ah,[di]                         ;icin j'nin karsisina hangi elemanin gelecegini biliyorum.O zaman ascii karsiliklari uzerinden asagidaki islemi yaparak 
mov al,[si]                         ;j yi degistirebilirim
sub ah,al
sub [bx],ah                         ;   sortedAlphabet ............. j(ascii:106) ................
lea di,sortedAlphabet               ; _ givingAlphabet ............. d(ascii:100) ................
lea si,givingAlphabet               ;----------------------------------------------------------------  
add bx,1                            ;                                         6          
mov dl,[bx]                         ; Burada bulunan 6 rakamini msg arrayinde gidip j'den cikarip cikan sonucu yine j degerinin bulundugu index'e yazarsam  
cmp dl,0                            ; eger j d'ye donusmus olur.Bu islemi yaptiktan sonrada sortedAlphabet ve givingAlphabet'in index'lerini tekrar kullanilmak 
jne change                          ; uzere en basa getirip msg'in adresini 1 arttirirsam j yerine artik g icin ayni islemi yapabilirim.En son dongu 0 
exit:                               ; karakterinin okunmasi ile son bulur.
ret                                 ;
