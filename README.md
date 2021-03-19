# Grupa7-BezimeniImperatori
## Tema projekta 
Program za stomatološku ordinaciju

## Opis teme
Najdosadniji dio posla koji dijele skoro svi radnici u različitim djelatnostima - pisanje papirologije. Doktori i medicinski radnici nisu nikakav izuzetak. Napretkom tehnologije sve više se koriste računari da olakšaju vođenje i pisanje iste kroz digitalnu evidenciju. Naš program pruža širok spektar opcija svim stomatolozima i medicinskim osobljem koji pomažu i asistiraju istim. Uz naš program nestaje potreba za ispunjavanje velikog broja papira kao i čuvanje velikog broja slika zubnog stanja pacijenata. Moguće je registrovati i updateovati stomatološki karton pacijenta uz veoma user-friendly GUI-a. Sve X-ray slike zuba koje su ključne za praćenje stanja pacijenta se mogu pohraniti u karton pacijenta, omogucavajući lak pregled čitave historije pacijenta kroz samo jedan klik. Ukoliko je potrebno, moći će se pregledati i specifično stanje svakog zuba, kao i historiju usluga koje su obavljene na istom kroz interaktivnu sliku obje vilice. Također, naš program olakšava posao stomatologa kroz jednostavni planner i prikazivanje svih zakazanih termina za tekući dan, kao i šta će biti potrebno uraditi na svakom od njih, omogućavajući asistentima da na vrijeme pripreme sve potrebne alate i time povećaju efikasnost i produktivnost same stomatološke ordinacije. Više nema potrebe ručno računati i voditi evidenciju o finansijama - program će voditi svu potrebnu evidenciju i računanje određenih zahtjeva ili usluga koje nudi ordinacija te formirati cijene za cjelokupnu ordinaciju kao i za pojedinačnog pacijenta. Za svakog pacijenta će se moći otvoriti finansijski karton u kojem možemo pročitati koliko je pacijent dužan. Ovaj sistem će također imati mogućnost za plačanje ratama na proizvoljan broj mjeseci. Najveća mana kod digitalne evidencije jeste nemogućnost prenosa podataka sa jednog programa u drugi, time znatno limitirajući svoju upotrebljivost.
To neće biti problem sa našim programom koji će imati API te ćemo moći bez problema povezivati sa drugim programima ili exportovati sve podatke i pojedinačne kartone iz istog u neki drugi softver. S tim u vezi, postojat će mogućnost za backup svih podataka koji se trenutno nalaze tu, kao i njihovo uploadovanje na Cloud da ne bi izgubili sve podatke u slučaju kvara hardvera.  

## Akteri sistema 
- Doktori (stomatolozi i asistent stomatologa)
- Pacijenti
- Dobavljači (poslovni partneri)

## Prikaz funkcionalnih i nefunkcionalnih zahtjeva
  - Registracija korisnika (stomatolozi i medicinske sestre)

  - Kreiranje protokola pacijenta 
    - Bilježenje svakog pojedinačnog termina
    - Dodavanje Rentgen vilice
  
  - Kreiranje stomatološkog kartona pacijenta 
    - Registrovanje kartona pacijenata
    - Dodavanje protokola u karton pacijenata
   
  - Kreiranje, unos i upotreba interaktivne slike zuba

  - Preuzimanje i unošenje rentgen slike u karton pacijenta
  
  - Štampanje 
    - Štampanje protokola i/ili kartona za jednog ili više pacijenata
    - Štampanje stanja nakon dana, sedmice, mjeseca, godine (finansijske evidencije kao i učinka ordinacije i pojedinačnih stomatologa/asistenata)
  
  - Kreiranje plannera/rasporeda
    - Zakazivanje termina po danima/sedmicama
    - Pregled termina kao i dobijanje notifikacija za iste, koje uključuju mogućnost pregleda prethodno urađene usloge kao i šta je potrebno uraditi u tekućem terminu
    - Pregled rasporeda slobodnih termina 

  - Vođenje evidencije o finansijama
    - Kreiranje cjenovnika usluga kao i mogućnost naknadne promjene cijena
    - Vođenje evidencije o ratama kao i zaduženjima pacijenata
    - Vođenje evidencije o zaduženjima prema i od poslovnih partnera 
    - Izračunavanje cijena prema uslugama (npr. prema broju liječenih zuba, broju anestezija, ...)
    - Čuvanje historije svih računa u bazi podataka

  - Implementiranje sistema za članarinu
    - Dodavanje članske kartice za specifičnog pacijenta
    - Obračunavanje cijene usluga uz specifičan varijabilan popust

  - Prikazivanje video demonstracija upotrebe programa za one koji se nisu susretali sa istim

  - Čuvanje i uploadovanje svih podataka na Cloud, kao i mogućnost exportovanja istih te pravljenje backup fajla sa svim podacima

  - Kreiranje sistema za online interakciju sa pacijentima

  - Kreiranje različitih notifikacija u skladu sa vremenima zakaznih termina kao i pauza u slučaju nezakazanih termina
