# Grupa7-BezimeniImperatori

![rsz_163197576_440102223759119_3829249456402551317_n](https://user-images.githubusercontent.com/72881957/111922846-95f00b00-8a9c-11eb-91a0-1172b000775e.png)

Bezimene Imperatore čine:  
  
Awad (awadić) Abdullah  
Hasanić (keno-noke-karaoke) Kenan   
Hodžić (dr. hodža) Adnan  
Isić (hale) Hamza  


## Tema projekta 
Web aplikacija za stomatološku ordinaciju - JAWS

## Kratki uvod 
Prilikom razgovora jednog našeg člana tima sa užim članom porodice koji je u skorije vrijeme otvorio stomatološku ordinaciju, dobili smo informaciju da je za sam rad iste potreban valjan softver. Softver, odnosno program, koji bi ispunjavao korisničke zahtjeve u velikoj mjeri, uz vizuelno zadovoljavajući izgled. Uzimajući  u obzir da postojeći programi do kojih se moglo doći, ne ispunjavaju sve tražene zahtjeve. Mi smo, uz veliki optimizam, ovaj problem uzeli kao predmet našeg projekta.
Daljne informacije o samom programu, odnosno web aplikaciji, su nastale uz intervju obavljen sa pomenutim stomatologom, te istraživanjem svih članova tima.

## Opis teme
Najdosadniji dio posla koji dijele skoro svi radnici u različitim djelatnostima - pisanje papirologije. Doktori i medicinski radnici nisu nikakav izuzetak. Napretkom tehnologije sve više se koriste računari da olakšaju vođenje i pisanje iste kroz digitalnu evidenciju. JAWS pruža širok spektar opcija svim stomatolozima i medicinskim osobljem koji pomažu i asistiraju istim. Uz JAWS nestaje potreba za ispunjavanje velikog broja papira kao i čuvanje velikog broja slika zubnog stanja pacijenata. Naš program će služiti kao posrednik između pacijenta i ordinacije, te najvažnije kao ubrzanje efikasnosti vođenja jedne ordinacije. Svim potrebnim informacijama značajnim za stomatologa će se moći pristupiti sa jednog mjesta, uključujući i informacije vezane za pacijente, čime se pojednostavljuje vođenje evidencije svih potencijalnih pacijenata. Veliki značaj se stavlja na pacijente, odnosno olakšanje njihovom pristupu ugovaranja termina. Usavršavanjem sistema se nastoji limitirati napor pacijenta koji će biti potreban za dogovor određene usluge.
Većina stomatologa ima jako velik broj pacijenata koje bi bilo veoma teško pretražiti, naći ili sortirati pacijente za pregled analitike stomatološke ordinacije što uz JAWS neće biti problem. 

_Za više informacija možete pročitati specifikaciju projekta (PDF dokument)._ 
## Akteri sistema 
- Doktori (stomatolozi i asistent stomatologa)
- Pacijenti
- Dobavljači (poslovni partneri)

## Prikaz funkcionalnih i nefunkcionalnih zahtjeva
  - Registrovanje korisnika (stomatolozi i medicinske sestre)

  - Kreiranje stomatološke usluge pacijenta 
    - Unos podataka pacijenta i opis urađenog zahvata
    - Dodavanje Rentgen vilice
  
  - Kreiranje stomatološkog kartona pacijenta 
    - Dodavanje stomatološke usluge u karton pacijenata (ažuriranje postojećeg kartona)
    - Preuzimanje i skladištenje RTG snimaka u kartonu odnosno protokolu (ortopana, retroalveolarnih i ostalih 2D snimaka) u odgovarajućem formatu

  - Kreiranje i popunjavanje knjige protokola

  - Simulacija stanja vilice preko LED lampica uz tri moguća stanja zuba
  
  - Kreiranje rasporeda termina

  - Pregledanje rasporeda slobodnih termina  
    - Zakazivanje termina
   
  - Pregledanje termina kao i dobijanje notifikacija za iste, koje uključuju mogućnost pregleda prethodno urađene usluge kao i šta je potrebno uraditi u tekućem termin
  
  - Pregledanje cjenovnika

  - Kreiranje cjenovnika usluga kao i mogućnost naknadne promjene cijena

  - Plaćanje usluga

  - Autoformiranje cijena prema uslugama (npr. prema broju liječenih zuba, broju anestezija, ...) korištenjem algoritma za izračunavanje popusta uzimajući u obzir količinu urađenih usluga, vremenski period u kojem su te usluge urađene kao i posjedovanje članske kartice

  - Kreiranje i provjeravanje potrošačkih kartica za najvjernije pacijente (loyalty card)
  
  - Prikazivanje video demonstracija upotrebe programa za one koji se nisu susretali sa istim
  
  - Slanje poruka stomatologu/stomatološkom tehničaru 

  - Omogućavanje sortiranja/traženja pacijenata po imenu/prezimenu, po datumu, ...   

  - Kreiranje različitih pop-up notifikacija u skladu sa vremenima zakaznih termina kao i pauza u slučaju slobodnih termina
   
  - Implementiranje adresara sa kontakt podacima (poslovni partneri)
