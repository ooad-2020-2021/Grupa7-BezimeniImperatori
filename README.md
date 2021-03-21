# Grupa7-BezimeniImperatori

<p align="center">
  <img width="460" height="300" src="https://ibb.co/pxFyDXQ">
</p>

## Tema projekta 
Program za stomatološku ordinaciju - JAWS

## Kratki uvod 
Prilikom razgovora jednog našeg člana tima sa užim članom porodice koji je u skorije vrijeme otvorio stomatološku ordinaciju, dobili smo informaciju da je za sam rad iste potreban valjan softver. Softver, odnosno program, koji bi ispunjavao korisničke zahtjeve u velikoj mjeri, uz vizuelno zadovoljavajući izgled. Uzimajući  u obzir da postojeći programi do kojih se moglo doći, ne ispunjavaju sve tražene zahtjeve. Mi smo, uz veliki optimizam, ovaj problem uzeli kao predmet našeg projekta.
Daljne informacije o samom programu, odnosno sistemu, su nastale uz intervju obavljen sa pomenutim stomatologom, te istraživanjem svih članova tima.

## Opis teme
Najdosadniji dio posla koji dijele skoro svi radnici u različitim djelatnostima - pisanje papirologije. Doktori i medicinski radnici nisu nikakav izuzetak. Napretkom tehnologije sve više se koriste računari da olakšaju vođenje i pisanje iste kroz digitalnu evidenciju. JAWS pruža širok spektar opcija svim stomatolozima i medicinskim osobljem koji pomažu i asistiraju istim. Uz JAWS nestaje potreba za ispunjavanje velikog broja papira kao i čuvanje velikog broja slika zubnog stanja pacijenata. Naš program će služiti kao posrednik između pacijenta i ordinacije, te najvažnije kao ubrzanje efikasnosti vođenja jedne ordinacije. Sve potrebne informacije značajne za stomatologa će se moći pristupiti sa jednog mjesta, uključujući i informacije vezane za pacijente, čime se pojednostavljuje vođenje evidencije svih potencijalnih pacijenata. Veliki značaj se stavlja na pacijente, odnosno olakšanje njihovom pristupu ugovaranja termina. Usavršavanjem sistema se nastoji limitirati napor pacijenta koji će biti potreban za dogovor određene usluge.

Moguće je registrovati i ažurirati stomatološki karton pacijenta uz korištenje veoma user-friendly GUI-a. Sve RTG slike zuba koje su ključne za praćenje stanja pacijenta se mogu pohraniti u karton pacijenta, omogučavajući lak pregled čitave historije pacijenta kroz samo jedan klik. Ukoliko je potrebno, moći će se pregledati i specifično stanje svakog zuba, kao i cijelih usta kroz RTG sliku obje vilice. Također, JAWS olakšava posao stomatologa kroz jednostavni planner i prikazivanje svih zakazanih termina za tekući dan, kao i informacije o zahvatima koje će biti potrebno obaviti, omogućavajući asistentima da na vrijeme pripreme sve esencijalne alate i time povećaju efikasnost i produktivnost same stomatološke ordinacije. JAWS također ima implementiran sistem notificiranja, koji neće prekidati korisnika u onome što trenutno radi. Neće biti potrebno ručno računati i voditi evidenciju o finansijama - program će voditi svu potrebnu evidenciju i računanje određenih usluga koje nudi ordinacija te formirati cijene za cjelokupnu ordinaciju kao i za pojedinačnog pacijenta.
  
Najveća mana kod digitalne evidencije jeste nemogućnost prenosa podataka sa jednog programa u drugi, time znatno limitirajući svoju upotrebljivost.
To neće biti problem sa našim programom koji će imati API te ćemo moći bez problema povezivati sa drugim programima.

## Akteri sistema 
- Doktori (stomatolozi i asistent stomatologa)
- Pacijenti
- Dobavljači (poslovni partneri)

## Prikaz funkcionalnih i nefunkcionalnih zahtjeva
  - Registrovanje korisnika (stomatolozi i medicinske sestre)

  - Kreiranje protokola pacijenta 
    - Bilježenje svakog pojedinačnog termina
    - Dodavanje Rentgen vilice
  
  - Kreiranje stomatološkog kartona pacijenta 
    - Dodavanje protokola u karton pacijenata (ažuriranje postojećeg kartona)

  
  - Preuzimanje i skladištenje RTG snimaka u kartonu odnosno protokolu (ortopana, retroalveolarnih i ostalih 2D snimaka) u odgovarajućem formatu
  
  - Kreiranje plannera/rasporeda

  - Pregledanje rasporeda slobodnih termina  
    - Zakazivanje termina
   
  - Pregledanje termina kao i dobijanje notifikacija za iste, koje uključuju mogućnost pregleda prethodno urađene usluge kao i šta je potrebno uraditi u tekućem termin
  
    
  - Pregledanje cjenovnika

  - Kreiranje cjenovnika usluga kao i mogućnost naknadne promjene cijena

  - Plaćanje usluga

  - Autoformiranje cijena prema uslugama (npr. prema broju liječenih zuba, broju anestezija, ...) korištenjem algoritma za izračunavanje popusta uzimajući u obzir količinu urađenih usluga, vremenski period u kojem su te usluge urađene kao i posjedovanje članske kartice

  - Implementiranje sistema za članarinu
    - Dodavanje članske kartice za specifičnog pacijenta

  - Prikazivanje video demonstracija upotrebe programa za one koji se nisu susretali sa istim
  
  - Kreiranje podrške za korisnike

  - Kreiranje različitih pop-up notifikacija u skladu sa vremenima zakaznih termina kao i pauza u slučaju slobodnih termina
   
  - Implementiranje adresara sa kontakt podacima (poslovni partneri)

  - API
