# GrafikaP1
Predmetni zadatak 1 (PZ1) – 25 poena
Cilj predmetnog zadatka 1 je iscrtavanje grafa elektroenergetske mreže.
Graf mreže je potrebno iscrtati na osnovu Geographic.xml fajla (dat u okviru materijala za prvi
termin vežbi). Graf aproksimira mrežu na ortogonalni prikaz. Prvo je potrebno da se površina za
iscrtavanje podeli na (“zamišljene”) podeoke, a što je više takvih podeoka definisano, to će prikaz biti
detaljniji. Potom se učitavaju koordinate iz *.xml fajla i crtaju se entiteti mreže, tako što se
aproksimiraju na najbliži podeok na površini za crtanje.
Entiteti mreže se iscrtavaju tako što se iscrtava grafički element (može biti geometrijski oblik ili slika)
koja će predstavljati datu vrstu entiteta (Substation, Node ili Switch). Za svaki grafički element se
prikazuje ToolTip sa informacijom koji entitet se tu nalazi. Entiteti se mogu iscrtavati na dva različita
načina:
1-a: Entiteti mreže se aproksimiraju na najbliži podeok i u tom slučaju se mogu preklapati. Ako dođe
do preklapanja, na datom mestu se iscrtava neka posebna sličica koja označava grupu, a u ToolTip-u
se prikazuju informacije o svakom entitetu koji se tu nalazi. (1 poen manje)
1-b: Entiteti mreže se aproksimiraju na najbliži slobodni podeok, bez preklapanja. U ovom slučaju
treba voditi računa o minimalnom broju podeoka kako bi bilo prostora za sve.
Predlog: minimum 100x100
Vodovi, koji spajaju entitete, se crtaju kao prave linije i ukoliko je potrebno, linija mora da skreće
samo pod pravim uglom. Posmatraju se samo Start i End Nodes u linijama, a Vertices se ignorišu.
Iscrtavaju se samo one linije čiji Start i End Node postoje u kolekcijama entiteta. Ostali vodovi se
ignorišu. Treba ignorisati ponovno iscrtavanje vodova izmedju dva ista entiteta. Vod uvek mora da
kreće iz centra entiteta, ne iz gornjeg levog ugla (pozicije iscrtavanja) entiteta. Vodovi se mogu
iscrtavati na dva različita načina:
2-a: Vod se iscrtava kao najkraća putanja između dva entiteta (bilo koja najkraća). Ukoliko je na
zadatom mestu već iscrtan vod, ne crtati novi preko njega. Ako dođe do preseka vodova, označiti
presek. (2 poena manje)
2-b: Nalazi se najkraći mogući put BEZ presecanja sa već postojećim iscrtanim vodovima (kroz
upotrebu BFS algoritma). U drugom prolazu se iscrtavaju vodovi za koje u prvom prolazu nije bilo
moguće naći put bez presecanja i tada se i oni iscrtavaju uz označavanje tačaka preseka.
Predlog: Algoritam započeti od neka dva entiteta koja imaju najmanju udaljenost na gridu. Naći ih
automatski ili ručno.
Desnim klikom na vod koji spaja dva entiteta se pokreće animacija koja traje jednu sekundu i u kojoj
se grafički elementi koji prikazuju entitete uvećavaju dva puta i menjaju boju, tako da je ona različita
od ostalih, kako bi korisnik znao koji su entiteti povezani tim vodom. Elementi ostaju obojeni
različitom bojom dok se ne klikne na neku drugu liniju.
Potrebno je omogućiti zumiranje prikaza mreže tako da se pomoću skrol-barova može pomerati
pogled nad zumiranom delu mreže, kao i da se prikaz mreže može „odzumirati“.
Na vrhu prozora, potrebno je ponuditi korisniku opcije da se iscrtani graf mreže može dopuniti
oblicima i/ili tekstom:
a. Draw Ellipse: izborom ove opcije, potom klikom na desni taster miša na površini Canvas-a
otvara se novi prozor u okviru kojeg se unose i biraju atributi elipse (dužine poluprečnika,
debljina konturne linije, boje) posle čega se iscrtava elipsa po zadatim atributima. Takođe,
opciono ponuditi korisniku da unese tekst koji će biti napisan na površini iscrtane elipse i
izbor boje teksta (veličina teksta je fiksirana).
b. Draw Polygon: izborom ove opcije, potom klikom na desni taster miša na Canvas određuju
se tačke koje će ograničiti površinu poligona. Kada se sve tačke odrede, levim klikom na
površini Canvas-a otvara se novi prozor u okviru kojeg se unose i biraju atributi poligona
(debljina konturne linije, boje) posle čega se iscrtava poligon po zadatim atributima. Takođe,
opciono ponuditi korisniku da unese tekst koji će biti napisan na površini iscrtanog poligona i
izbor boje teksta (veličina teksta je fiksirana).
c. Add Text: izborom ove opcije, potom klikom na desni taster miša na površini Canvas-a
otvara se novi prozor u okviru kojeg se unose i biraju atributi teksta: sam tekst, njegova boja
i veličina.
d. Undo: poništava iscrtavanje poslednjeg oblika ili teksta (nakon Clear vraća sve što je
obrisano)
e. Redo: vraća prethodno uklonjen oblik ili tekst
f. Clear: prazni Canvas od svih iscrtanih oblika ili teksta
Napomene:
- Tooltip-ovi prikazuju ID i ime entiteta, a prikazuju se i za veze (vodove).
- Svi oblici (i tekst) se iscrtavaju tako da im je gornji levi ugao pozicija gde je pokazivačem miša
kliknuto da bi se inicirala akcija crtanja. Kada se kaže “na površinu Canvas-a” tu se misli i na
prethodno nacrtane oblike i tekst (mogu se iscrtavati jedni preko drugih).
- Svaki od iscrtanih oblika i tekst treba da ima opciju da se klikom levim tasterom miša na njega mogu
menjati njegovi atributi izgleda (boje i debljine konturna linije, a za tekst samo njegova boja i
veličina).
- Prilikom bojenja oblika koji se iscrtavaju preko mreže, ponuditi opciju da se izabranoj boji može dati
efekat providnosti.
BFS: Mreža se nekako mora čuvati u vidu podataka - matrica / niz nizova / liste. BFS uzima početni
čvor i proverava da li je to ciljni čvor. Potom uzima decu tog čvora i proverava da li je neki od njih
ciljni. Deca jednog čvora su susedni red i susedna kolona, a potrebno je čuvati listu svih predjenih
čvorova. Ukoliko prvo dete nije ciljni čvor, njegova deca se dodaju na listu čvorova za dalju proveru, a
potom se predje na drugo dete itd. Kada se dodje do ciljnog cvora, vrati se čitava putanja kojom se
pristiglo do cilja –> čuva se i lista predjenih čvorova koja su vodila do trenutnog čvora.
Primer: https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/
