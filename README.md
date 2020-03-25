# Grupa5-eSchedule
Tema: raspored

Tim "Kontrola magičnih sistema" Vam predstavlja projekat "eSchedule".

Članovi tima:
- Kenan Omić
- Seid Korać
- Miralem Memić

-------------------------------------------------------------------------------

"eSchedule" je aplikacija osmišljena od strane tima studenata Elektrotehničkog fakulteta u Sarajevu, prvenstveno za svrhu predmeta "Objektno orjentisana analiza i dizajn", ali i u svrhu pomaganja studentima i nastavnom osoblju fakulteta. Motivisani idejama, te stvarima za koje mislimo da su potrebne prije svega nama kao studentima, zatim i nastavnom osoblju, koristimo svoje stečeno znanje rada u C# i ASP.NET kako bi kreirali ovu aplikaciju.

Cilj aplikacije je da studentu ili uposleniku fakulteta pruži sve potrebne informacije o tome gdje i kada, dotična osoba mora da bude prisutna na fakultetu. Aplikacija koristi kreirani raspored fakulteta, te na osnovu njega pruža informacije korisniku.

-------------------------------------------------------------------------------

Funkcionalnosti primjenjene u aplikaciji:

Svaka osoba dobija informacije u zavisnosti od toga koji je tip korisnika. Na osnovu toga se također, određuju i privilegije koje posjedujete kao korisnik.

Ukoliko je korisnik "student", aplikacija mu pruža informacije vremena predavanja, laboratorijskih vježbi i ispita. Studenti također mogu preko aplikacije da biraju termine za laboratorijske vježbe, te da šalju zahtjeve za razmjenu grupe drugim studentima.
Ukoliko je kapacitet sale za laboratorijsku vježbu popunjen, student nije u mogućnosti da odabere taj termin za vježbe.

Za profesore i asistente, postoji mogućnost praćenja studenata prisutnih na predavanju i grupama. Profesori također, posjeduju i svoj admin panel preko kojeg mogu objavljivati najave vezane za predavanja i vježbe. Mogu također i pomjerati termine predavanja i lokacije predavanja, pri čemu svi studenti kojih se tiče ova promjena, dobijaju notifikaciju na svom uređaju.

Za svako predavanje i vježbu, data je i opcija opisa koji sadrži potrebne materijale za to predavanje odnosno vježbu, kao i neke potencijalne napomene.

Aplikacija ima mogućnost slanja svih vrsta notifikacija svim vrstama korisnika.

Aplikacija ima mogucnost praćenja prisustva pomoću QR kodova koji se prikazuju na predavanju/vježbama.

Aplikacija posjeduje Google Maps integraciju da bi se pratila lokacija predavanja.

Postoji i korisnik aplikacija tipa "admin",koji može da dodjeljuje i oduzima predmete profesorima. Admin također, kreira i radne verzije rasporeda predavanja ali i sekundarne, koji će svoju primjenu pronaći u nekom drugom periodu. Ukoliko admin promjeni tip jednog rasporeda na drugi, svaki korisnik će također koristiti odabrani raspored.

Aplikacija šalje informacije o praznicima, neradnim danima i vanrednim situacijama. Studenti za praznike dobijaju čestitke.

-------------------------------------------------------------------------------

Aplikacija je autentična i isključivo plod mašte tima "Kontrola magičnih sistema".

Kontrola magičnih sistema

23/03/2020

Link za repozitorij na GitHubu:
https://github.com/ooad-2019-2020/Grupa5-eSchedule

