﻿using Microsoft.EntityFrameworkCore;
using ePozoriste.WebAPI.Services;
using System;
using System.Collections.Generic;
using ePozoriste.WebAPI.Database;
using System.IO;

namespace ePozoriste.WebAPI.DB
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Dodavanje uloga
            modelBuilder.Entity<Uloga>().HasData(
                new Uloga()
                {
                    UlogaId = 1,
                    Naziv = "Administrator",
                },
                new Uloga()
                {
                    UlogaId = 2,
                    Naziv = "Zaposlenik",
                });
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnik>().HasData(
                new Korisnik()
                {
                    KorisnikId = 1,
                    Ime = "admin",
                    Prezime = "admin",
                    Email = "admin@pozoriste.ba",
                    Telefon = "+387 62 580 661",
                    KorisnickoIme = "administrator",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",  //test
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ=="
                },

               new Korisnik()
               {
                   KorisnikId = 2,
                   Ime = "zaposlenik",
                   Prezime = "zaposlenik",
                   Email = "zaposlenik@pozoriste.ba",
                   Telefon = "+387 63 062 061",
                   KorisnickoIme = "zaposlenik",
                   LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",  //test
                   LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ=="
               });
            #endregion

            #region Dodavanje kupaca
            modelBuilder.Entity<Kupac>().HasData(
                new Kupac()
                {
                    KupacId = 8,
                    Ime = "Adi",
                    Prezime = "Mahmic",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "adi@fit.ba",
                    KorisnickoIme = "adi",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                },
                new Kupac()
                {
                    KupacId = 12,
                    Ime = "Faris",
                    Prezime = "Abaza",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "faris@fit.ba",
                    KorisnickoIme = "faris",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                },
                new Kupac()
                {
                    KupacId = 13,
                    Ime = "Enver",
                    Prezime = "Sejtanic",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "enver@fit.ba",
                    KorisnickoIme = "enver",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                },
                new Kupac()
                {
                    KupacId = 14,
                    Ime = "Sedina",
                    Prezime = "Gosto",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "enver@fit.ba",
                    KorisnickoIme = "enver",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                },
                new Kupac()
                {
                    KupacId = 15,
                    Ime = "Lejla",
                    Prezime = "Voloder",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "enver@fit.ba",
                    KorisnickoIme = "enver",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                },
                new Kupac()
                {
                    KupacId = 16,
                    Ime = "Mobile",
                    Prezime = "Application",
                    DatumRegistracije = new DateTime(2022, 1, 1),
                    Email = "mobile@fit.ba",
                    KorisnickoIme = "mobile",
                    LozinkaSalt = "MQMcaYOvUSDZuBDs/J08EQ==",
                    LozinkaHash = "Am57zAXwTvXXJDQZYr8UKy8MCF8=",
                    BrojTokena = 100,
                    BrojTelefona = "+387 61 100 200"
                }
            );
            #endregion

            #region Dodavanje glumaca
            modelBuilder.Entity<Glumac>().HasData(
                new Glumac()
                {
                    GlumacId = 1,
                    Ime = "Faris",
                    Prezime = "Glumac",
                    Email = "faris@fit.ba",
                    DatumRodjenja = new DateTime(2022, 01, 15),
                    BrojUgovora = 111,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 2,
                    Ime = "Jasmin",
                    Prezime = "Azemovic",
                    Email = "jasmin@fit.ba",
                    DatumRodjenja = new DateTime(2022, 01, 15),
                    BrojUgovora = 222,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 4,
                    Ime = "Enver",
                    Prezime = "Glumac",
                    Email = "enver@fit.ba",
                    DatumRodjenja = new DateTime(2022, 01, 15),
                    BrojUgovora = 333,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 5,
                    Ime = "Admir",
                    Prezime = "Glamocak",
                    Email = "admir@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 444,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 7,
                    Ime = "Denis",
                    Prezime = "Music",
                    Email = "denis@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 555,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 8,
                    Ime = "Amir",
                    Prezime = "Mujic",
                    Email = "amir@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 666,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 9,
                    Ime = "Mustafa",
                    Prezime = "Nadarevic",
                    Email = "mustafa@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 777,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 10,
                    Ime = "Dino",
                    Prezime = "Mujic",
                    Email = "dinom@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 888,
                    Slika = File.ReadAllBytes("actor.png"),
                },
                new Glumac()
                {
                    GlumacId = 11,
                    Ime = "Dino",
                    Prezime = "Dinic",
                    Email = "dinod@fit.ba",
                    DatumRodjenja = new DateTime(2020, 01, 15),
                    BrojUgovora = 999,
                    Slika = File.ReadAllBytes("actor.png"),
                }

                );
            #endregion

            #region Dodavanje korisnickih uloga korisnicima
            modelBuilder.Entity<KorisnikUloga>().HasData(
                new KorisnikUloga()
                {
                    KorisnikUlogaId = 1,
                    KorisnikId = 1,
                    UlogaId = 1,
                    DatumIzmjene = new DateTime(2022, 1, 1)
                },
                new KorisnikUloga()
                {
                    KorisnikUlogaId = 2,
                    KorisnikId = 2,
                    UlogaId = 2,
                    DatumIzmjene = new DateTime(2022, 1, 1)
                });
            #endregion

            #region Dodavanje gradova
            modelBuilder.Entity<Grad>().HasData(
                new Grad()
                {
                    GradId = 2,
                    Naziv = "Mostar"
                },
                new Grad()
                {
                    GradId = 3,
                    Naziv = "Bihac"
                },
                new Grad()
                {
                    GradId = 4,
                    Naziv = "Sarajevo"
                },
                new Grad()
                {
                    GradId = 5,
                    Naziv = "Zenica"
                },
                new Grad()
                {
                    GradId = 6,
                    Naziv = "Tuzla"
                },
                new Grad()
                {
                    GradId = 7,
                    Naziv = "Trebinje"
                },
                new Grad()
                {
                    GradId = 8,
                    Naziv = "Doboj"
                },
                new Grad()
                {
                    GradId = 9,
                    Naziv = "Kakanj"
                },
                new Grad()
                {
                    GradId = 10,
                    Naziv = "Banja Luka"
                }
                );
            #endregion

            #region Dodavanje sala
            modelBuilder.Entity<Sala>().HasData(
                new Sala()
                {
                    SalaId = 1,
                    Naziv = "Sala 1",
                    Kapacitet = 100,
                    Klimatizacija = true,
                    Lat = "43.338877",
                    Lng = "17.817077"
                }
                );
            #endregion

            #region Dodavanje nagradnih igara
            modelBuilder.Entity<NagradnaIgra>().HasData(
                new NagradnaIgra()
                {
                    NagradnaIgraId = 2,
                    Naziv = "Family first",
                    Opis = "Povedi svoju porodicu na predstavu i ostvarite popust od nevjerovatnih 20% na svaku kupljenu ulaznicu!",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 3,
                    Naziv = "Neka nagradna igra",
                    Opis = "Neki opis",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 4,
                    Naziv = "Novo u novoj godini",
                    Opis = "Ucestvuj u nagradnoj igri gdje cemo putem random broja izvuci sretnog dobitnika dvadeset tokena",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 5,
                    Naziv = "Rodjendanski poklon",
                    Opis = "Pozoriste casti svoje vjerne posjetioce povodom rodjendana",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 6,
                    Naziv = "Novogodisnji poklon",
                    Opis = "Pozoriste casti svoje vjerne posjetioce povodom novogodisnjih praznika",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 9,
                    Naziv = "Mostar nagradjuje",
                    Opis = "Mostar nagradjuje",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                },
                new NagradnaIgra()
                {
                    NagradnaIgraId = 10,
                    Naziv = "Lucky Day",
                    Opis = "test",
                    Pocetak = new DateTime(2022, 1, 1),
                    Kraj = new DateTime(2022, 12, 31),
                    KorisnikId = 1
                }
                );
            #endregion

            #region Dodavanje novosti
            modelBuilder.Entity<Novosti>().HasData(
                new Novosti()
                {
                    NovostiId = 2,
                    Naziv = "Iznenadjenje za vjerne posjetioce pozorista",
                    Tekst = "U iducem mjesecu nase pozoriste posjecuje poznati glumac",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                },
                new Novosti()
                {
                    NovostiId = 4,
                    Naziv = "Obilježavanje 70. pozorišne sezone",
                    Tekst = "Poklon publici predstava „Alfa Beta“",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                },
                new Novosti()
                {
                    NovostiId = 5,
                    Naziv = "Neka nova novost",
                    Tekst = "testiranje novosti",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                },
                new Novosti()
                {
                    NovostiId = 6,
                    Naziv = "Obilježavanje 25. novembra – Dana državnosti BiH",
                    Tekst = "U umjetničkom dijelu programa publika će imati priliku uživati u nastupu jedne od najboljih interpretatorki sevdalinke mlađe generacije",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                },
                new Novosti()
                {
                    NovostiId = 7,
                    Naziv = "Novo u pozoristu",
                    Tekst = "17. Međunarodni festival komedije ''Mostarska liska''",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                },
                new Novosti()
                {
                    NovostiId = 8,
                    Naziv = "Novo novo novo",
                    Tekst = "Pratite nasu fb stranicu i ocekujte iznenadjenja",
                    DatumVrijemeObjave = new DateTime(2022, 1, 1),
                    KorisnikId = 1,
                    Slika = File.ReadAllBytes("news.png")
                }
                );
            #endregion

            #region Dodavanje zanrova
            modelBuilder.Entity<Zanr>().HasData(
                new Zanr()
                {
                    ZanrId = 1,
                    Naziv = "Tragedija",
                },
                new Zanr()
                {
                    ZanrId = 3,
                    Naziv = "Drama",
                },
                new Zanr()
                {
                    ZanrId = 4,
                    Naziv = "Komedija",
                },
                new Zanr()
                {
                    ZanrId = 5,
                    Naziv = "Balet",
                }
                );
            #endregion


            #region Dodavanje predstava
            modelBuilder.Entity<Predstava>().HasData(
                new Predstava()
                {
                    PredstavaId = 1,
                    Naziv = "Jezeva Kucica",
                    Opis = "APredstava je nagrađena Velikom liskom za najbolju predstavu po izboru publike na 12. međunarodnom festivalu komedije “Mostarska liska 2015”.",
                    Reziser = "test",
                    Trajanje = 50,
                    ZanrId = 1
                },
                new Predstava()
                {
                    PredstavaId = 3,
                    Naziv = "Ne igraj na Engleze",
                    Opis = "Englezi za buducnost",
                    Reziser = "Rile iz Vize",
                    Trajanje = 55,
                    ZanrId = 3
                },
                new Predstava()
                {
                    PredstavaId = 6,
                    Naziv = "Smijeh",
                    Opis = "Uz ovu komediju smijeh je zagarantovan",
                    Reziser = "Admir Glamocak",
                    Trajanje = 55,
                    ZanrId = 1
                },
                new Predstava()
                {
                    PredstavaId = 19,
                    Naziv = "Dervis i smrt",
                    Opis = "„Ja sam bio u zatvoru da bi ljudi poput gradonačelnika mogli doći na vlast...i nepodnošljivijim...",
                    Reziser = "Erol Kadic",
                    Trajanje = 70,
                    ZanrId = 1
                },
                new Predstava()
                {
                    PredstavaId = 23,
                    Naziv = "Andjeli Babilona",
                    Opis = "Ideologije kao društveni sistemi, imaju svoju strukturu, norme, specifične uloge, ali i svojstvene komunikacijske kodove putem kojih šire svoje ideje na druge članove ideološkog sistema",
                    Reziser = "Mujo Antic",
                    Trajanje = 60,
                    ZanrId = 5
                },
                new Predstava()
                {
                    PredstavaId = 24,
                    Naziv = "Dolina smrti",
                    Opis = "Predstava o dolini smrti",
                    Reziser = "Edina Adilovic",
                    Trajanje = 55,
                    ZanrId = 4
                },
                new Predstava()
                {
                    PredstavaId = 25,
                    Naziv = "Adio",
                    Opis = "Predstava o dvoje mladih za vrijeme rata u BIH",
                    Reziser = "Antonio Mujkanovic",
                    Trajanje = 100,
                    ZanrId = 4
                },
                new Predstava()
                {
                    PredstavaId = 26,
                    Naziv = "Posljednji udarac",
                    Opis = "Za sve one koji vole drame",
                    Reziser = "Adla Agic",
                    Trajanje = 77,
                    ZanrId = 1
                },
                new Predstava()
                {
                    PredstavaId = 29,
                    Naziv = "Cvijece",
                    Opis = "Ljubavna prica koja ce vas rastuziti",
                    Reziser = "Ana Agic",
                    Trajanje = 80,
                    ZanrId = 5
                },
                new Predstava()
                {
                    PredstavaId = 30,
                    Naziv = "Tehnoloski visak",
                    Opis = "Prica o trgovini na Balkanu",
                    Reziser = "Dzemila Janjic",
                    Trajanje = 75,
                    ZanrId = 3
                }
                );
            #endregion

            #region Dodavanje prikazivanja
            modelBuilder.Entity<Prikazivanje>().HasData(
                new Prikazivanje()
                {
                    PrikazivanjeId = 1,
                    DatumPrikazivanja = new DateTime(2022, 3, 12, 20, 00, 00),
                    SalaId = 1,
                    PredstavaId = 1,
                    Cijena = 8
                },
                new Prikazivanje()
                {
                    PrikazivanjeId = 2,
                    DatumPrikazivanja = new DateTime(2022, 3, 13, 20, 00, 00),
                    SalaId = 1,
                    PredstavaId = 3,
                    Cijena = 15
                },
                new Prikazivanje()
                {
                    PrikazivanjeId = 3,
                    DatumPrikazivanja = new DateTime(2022, 3, 14, 20, 00, 00),
                    SalaId = 1,
                    PredstavaId = 30,
                    Cijena = 7
                },
                new Prikazivanje()
                {
                    PrikazivanjeId = 4,
                    DatumPrikazivanja = new DateTime(2022, 3, 15, 20, 00, 00),
                    SalaId = 1,
                    PredstavaId = 19,
                    Cijena = 9
                }
                );
            #endregion

            #region Dodavanje sjedišta
            modelBuilder.Entity<Sjediste>().HasData(
                new Sjediste
                {
                    SjedisteId = 4803,
                    Red = 1,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4902,
                    Red = 10,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4903,
                    Red = 10,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4904,
                    Red = 3,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4905,
                    Red = 3,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4906,
                    Red = 3,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4907,
                    Red = 3,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4908,
                    Red = 4,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4909,
                    Red = 4,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4910,
                    Red = 4,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4911,
                    Red = 4,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4912,
                    Red = 4,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4913,
                    Red = 4,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4914,
                    Red = 4,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4915,
                    Red = 4,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4916,
                    Red = 4,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4917,
                    Red = 4,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4918,
                    Red = 5,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4919,
                    Red = 5,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4920,
                    Red = 5,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4921,
                    Red = 5,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4922,
                    Red = 5,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4923,
                    Red = 5,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4924,
                    Red = 5,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4925,
                    Red = 3,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4926,
                    Red = 5,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4927,
                    Red = 3,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4928,
                    Red = 3,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4929,
                    Red = 1,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4930,
                    Red = 1,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4931,
                    Red = 1,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4932,
                    Red = 1,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4933,
                    Red = 1,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4934,
                    Red = 1,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4935,
                    Red = 1,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4936,
                    Red = 1,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4937,
                    Red = 1,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4938,
                    Red = 2,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4939,
                    Red = 2,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4940,
                    Red = 2,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4941,
                    Red = 2,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4942,
                    Red = 2,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4943,
                    Red = 2,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4944,
                    Red = 2,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4945,
                    Red = 2,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4946,
                    Red = 2,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4947,
                    Red = 2,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4948,
                    Red = 3,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4949,
                    Red = 3,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4950,
                    Red = 3,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4951,
                    Red = 5,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4952,
                    Red = 5,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4953,
                    Red = 6,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4954,
                    Red = 8,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4955,
                    Red = 8,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4956,
                    Red = 8,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4957,
                    Red = 9,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4958,
                    Red = 9,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4959,
                    Red = 9,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4960,
                    Red = 9,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4961,
                    Red = 9,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4962,
                    Red = 9,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4963,
                    Red = 9,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4964,
                    Red = 9,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4965,
                    Red = 9,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4966,
                    Red = 9,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4967,
                    Red = 10,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4968,
                    Red = 10,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4969,
                    Red = 10,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4970,
                    Red = 10,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4971,
                    Red = 10,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4972,
                    Red = 10,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4973,
                    Red = 10,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4974,
                    Red = 10,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4975,
                    Red = 8,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4976,
                    Red = 8,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4977,
                    Red = 8,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4978,
                    Red = 8,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4979,
                    Red = 6,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4980,
                    Red = 6,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4981,
                    Red = 6,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4982,
                    Red = 6,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4983,
                    Red = 6,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4984,
                    Red = 6,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4985,
                    Red = 6,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4986,
                    Red = 6,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4987,
                    Red = 6,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4988,
                    Red = 7,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4990,
                    Red = 7,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4991,
                    Red = 7,
                    Kolona = 4,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4992,
                    Red = 7,
                    Kolona = 5,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4993,
                    Red = 7,
                    Kolona = 6,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4994,
                    Red = 7,
                    Kolona = 7,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4995,
                    Red = 7,
                    Kolona = 8,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4996,
                    Red = 7,
                    Kolona = 9,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4997,
                    Red = 7,
                    Kolona = 10,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4998,
                    Red = 8,
                    Kolona = 1,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 4999,
                    Red = 8,
                    Kolona = 2,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 5000,
                    Red = 8,
                    Kolona = 3,
                    SalaId = 1,
                },
                new Sjediste
                {
                    SjedisteId = 5001,
                    Red = 7,
                    Kolona = 3,
                    SalaId = 1,
                }
                );
            #endregion

            #region Dodavanje glumac-predstava
            modelBuilder.Entity<GlumacPredstava>().HasData(
                new GlumacPredstava
                {
                    GlumacPredstavaId = 1,
                    GlumacId = 1,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 10,
                    GlumacId = 4,
                    PredstavaId = 3
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 11,
                    GlumacId = 5,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 12,
                    GlumacId = 5,
                    PredstavaId = 6
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 13,
                    GlumacId = 5,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 15,
                    GlumacId = 8,
                    PredstavaId = 6
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 16,
                    GlumacId = 8,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 17,
                    GlumacId = 8,
                    PredstavaId = 3
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 18,
                    GlumacId = 9,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 19,
                    GlumacId = 10,
                    PredstavaId = 1
                },
                new GlumacPredstava
                {
                    GlumacPredstavaId = 20,
                    GlumacId = 10,
                    PredstavaId = 3
                }
                );
            #endregion
            #region Dodavanje komentara
            modelBuilder.Entity<Komentar>().HasData(
                new Komentar
                {
                    KomentarId = 1,
                    Sadrzaj = "Top",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = true,
                    KupacId = 8,
                    PredstavaId = 1
                },
                new Komentar
                {
                    KomentarId = 2,
                    Sadrzaj = "ovo je komentar",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = false,
                    KupacId = 8,
                    PredstavaId = 3
                },
                new Komentar
                {
                    KomentarId = 3,
                    Sadrzaj = "komentar test",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = false,
                    KupacId = 8,
                    PredstavaId = 6
                },
                new Komentar
                {
                    KomentarId = 7,
                    Sadrzaj = "Vrlo dobra predstava, sve preporuke",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = true,
                    KupacId = 16,
                    PredstavaId = 30
                },
                new Komentar
                {
                    KomentarId = 8,
                    Sadrzaj = "Nije ispunilo moja ocekivanja.",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = true,
                    KupacId = 16,
                    PredstavaId = 23
                },
                new Komentar
                {
                    KomentarId = 9,
                    Sadrzaj = "Predobro",
                    VrijemeKreiranja = new DateTime(2022, 01, 07, 11, 12, 13),
                    Odobrena = false,
                    KupacId = 16,
                    PredstavaId = 26
                }
                );
            #endregion
            #region Dodavanje kupaca na nagradne igre
            modelBuilder.Entity<KupacNagradnaIgra>().HasData(
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 5,
                    NagradnaIgraId = 2,
                    KupacId = 8
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 6,
                    NagradnaIgraId = 2,
                    KupacId = 14
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 7,
                    NagradnaIgraId = 3,
                    KupacId = 8
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 8,
                    NagradnaIgraId = 4,
                    KupacId = 8
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 9,
                    NagradnaIgraId = 10,
                    KupacId = 12
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 10,
                    NagradnaIgraId = 2,
                    KupacId = 12
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 11,
                    NagradnaIgraId = 3,
                    KupacId = 12
                },
                new KupacNagradnaIgra
                {
                    KupacNagradnaIgraId = 12,
                    NagradnaIgraId = 4,
                    KupacId = 16
                }
                );
            #endregion

            #region Dodavanje sponzora
            modelBuilder.Entity<Sponzor>().HasData(
                new Sponzor
                {
                    SponzorId = 1,
                    Naziv = "FIT",
                    BrojTelefona = "036 111 111"
                },
                new Sponzor
                {
                    SponzorId = 2,
                    Naziv = "ETF",
                    BrojTelefona = "033 123 456"
                },
                new Sponzor
                {
                    SponzorId = 3,
                    Naziv = "NSoft",
                    BrojTelefona = "036 222 222"
                },
                new Sponzor
                {
                    SponzorId = 4,
                    Naziv = "Grad Mostar",
                    BrojTelefona = "036 123 123"
                },
                new Sponzor
                {
                    SponzorId = 6,
                    Naziv = "Bingo",
                    BrojTelefona = "033 111 111"
                },
                new Sponzor
                {
                    SponzorId = 7,
                    Naziv = "Grad Sarajevo",
                    BrojTelefona = "033 123 123"
                }

                );
            #endregion

            #region Dodavanje uplata
            modelBuilder.Entity<Uplata>().HasData(
                new Uplata
                {
                    UplataId = 1,
                    Naziv = "skolarina",
                    Svrha = "skolarina fit",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 1
                },
                new Uplata
                {
                    UplataId = 2,
                    Naziv = "Racunari",
                    Svrha = "Potrebna nova oprema",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 1
                },
                new Uplata
                {
                    UplataId = 3,
                    Naziv = "Uplata od ETF",
                    Svrha = "Podrska radu pozorista",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 2
                },
                new Uplata
                {
                    UplataId = 4,
                    Naziv = "podrska pozoristu",
                    Svrha = "test",
                    Iznos = 7000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 1
                },
                new Uplata
                {
                    UplataId = 5,
                    Naziv = "Stipendiranje",
                    Svrha = "Stipendiranje mladih glumaca",
                    Iznos = 700,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 4
                },
                new Uplata
                {
                    UplataId = 6,
                    Naziv = "Bingo uplata",
                    Svrha = "Stolice",
                    Iznos = 2000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 6
                },
                new Uplata
                {
                    UplataId = 7,
                    Naziv = "Naziv",
                    Svrha = "test",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 3
                },
                new Uplata
                {
                    UplataId = 8,
                    Naziv = "Hrana i pice",
                    Svrha = "Hrana",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 6
                },
                new Uplata
                {
                    UplataId = 9,
                    Naziv = "Uplata grad Mostar",
                    Svrha = "Ocuvanje okolisa",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 4
                },
                new Uplata
                {
                    UplataId = 10,
                    Naziv = "Nova uplata",
                    Svrha = "Troskovi struje",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 1
                },
                new Uplata
                {
                    UplataId = 11,
                    Naziv = "Donacija grada Sarajevo",
                    Svrha = "Ocuvanje kvalitete rada",
                    Iznos = 1000,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 2
                },
                new Uplata
                {
                    UplataId = 12,
                    Naziv = "Kostimi",
                    Svrha = "Za bolje predstave",
                    Iznos = 800,
                    DatumUplate = new DateTime(2022, 1, 1, 11, 22, 33),
                    SponzorId = 7
                }

                );
            #endregion
            #region Dodavanje ulaznica
            modelBuilder.Entity<Ulaznica>().HasData(
                new Ulaznica
                {
                    PrikazivanjeId = 2,
                    SjedisteId = 4934,
                    KupacId = 8,
                    RezervacijaId = 2,
                    Qrkod = new byte[0],
                    UlaznicaId = 1
                },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4943,
                        KupacId = 8,
                        RezervacijaId = 3,
                        Qrkod = new byte[0],
                        UlaznicaId = 2
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4915,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 3
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4911,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 4
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4993,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 5
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4993,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 6
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4993,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 7
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4803,
                        KupacId = 8,
                        RezervacijaId = 3,
                        Qrkod = new byte[0],
                        UlaznicaId = 8
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4933,
                        KupacId = 8,
                        RezervacijaId = 3,
                        Qrkod = new byte[0],
                        UlaznicaId = 9
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4933,
                        KupacId = 8,
                        RezervacijaId = 3,
                        Qrkod = new byte[0],
                        UlaznicaId = 10
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4905,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 11
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4905,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 12
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4967,
                        KupacId = 8,
                        RezervacijaId = 4,
                        Qrkod = new byte[0],
                        UlaznicaId = 13
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4902,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 15
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4902,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 16
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4930,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 17
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4930,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 18
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4964,
                        KupacId = 8,
                        RezervacijaId = 3,
                        Qrkod = new byte[0],
                        UlaznicaId = 19
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4945,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 20
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4957,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 21
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 3,
                        SjedisteId = 4803,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 22
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4959,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 23
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4919,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 28
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4921,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 29
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4923,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 30
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4982,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 31
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 2,
                        SjedisteId = 4974,
                        KupacId = 8,
                        RezervacijaId = 2,
                        Qrkod = new byte[0],
                        UlaznicaId = 32
                    },
                    new Ulaznica
                    {
                        PrikazivanjeId = 3,
                        SjedisteId = 4977,
                        KupacId = 16,
                        RezervacijaId = 11,
                        Qrkod = new byte[0],
                        UlaznicaId = 33
                    }
                );
            #endregion

            #region Dodavanje rezervacija
            modelBuilder.Entity<Rezervacije>().HasData(
              new Rezervacije
              {
                  RezervacijaId = 2,
                  DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                  Odobrena = true,
                  BrojRezervacije = 3597,
                  KupacId = 8,
                  PrikazivanjeId = 1
              },
                    new Rezervacije
                    {
                        RezervacijaId = 3,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 2710,
                        KupacId = 8,
                        PrikazivanjeId = 2
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 4,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 7200,
                        KupacId = 8,
                        PrikazivanjeId = 3
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 11,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 5384,
                        KupacId = 16,
                        PrikazivanjeId = 4
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 12,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 4276,
                        KupacId = 16,
                        PrikazivanjeId = 1
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 13,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 9240,
                        KupacId = 8,
                        PrikazivanjeId = 2
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 14,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 8619,
                        KupacId = 8,
                        PrikazivanjeId = 3
                    },
                    new Rezervacije
                    {
                        RezervacijaId = 15,
                        DatumRezervacije = new DateTime(2022, 2, 1, 11, 22, 33),
                        Odobrena = true,
                        BrojRezervacije = 8021,
                        KupacId = 8,
                        PrikazivanjeId = 4
                    }

                );
            #endregion


            #region Dodavanje notifikacija
            modelBuilder.Entity<Notifikacija>().HasData(
                new Notifikacija
                {
                    NotifikacijaId = 1,
                    DatumSlanja = new DateTime(2022, 2, 1, 11, 22, 33),
                    NovostiId = 4,
                    IsProcitano = true
                },
                new Notifikacija
                {
                    NotifikacijaId = 2,
                    DatumSlanja = new DateTime(2022, 2, 5, 11, 22, 33),
                    NovostiId = 5,
                    IsProcitano = false
                },
                new Notifikacija
                {
                    NotifikacijaId = 3,
                    DatumSlanja = new DateTime(2022, 2, 10, 11, 22, 33),
                    NovostiId = 6,
                    IsProcitano = true
                },
                new Notifikacija
                {
                    NotifikacijaId = 4,
                    DatumSlanja = new DateTime(2022, 2, 15, 11, 22, 33),
                    NovostiId = 7,
                    IsProcitano = false
                },
                new Notifikacija
                {
                    NotifikacijaId = 5,
                    DatumSlanja = new DateTime(2022, 2, 20, 11, 22, 33),
                    NovostiId = 8,
                    IsProcitano = false
                }
                );
            #endregion


            #region Dodavanje predstava uplata
            modelBuilder.Entity<PredstavaUplata>().HasData(
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 3,
                        DatumUplate = new DateTime(2022, 3, 2, 11, 22, 33),
                        PredstavaId = 1,
                        UplataId = 1
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 4,
                        DatumUplate = new DateTime(2022, 3, 4, 11, 22, 33),
                        PredstavaId = 1,
                        UplataId = 2
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 5,
                        DatumUplate = new DateTime(2022, 3, 6, 11, 22, 33),
                        PredstavaId = 3,
                        UplataId = 1
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 6,
                        DatumUplate = new DateTime(2022, 3, 8, 11, 22, 33),
                        PredstavaId = 6,
                        UplataId = 4
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 7,
                        DatumUplate = new DateTime(2022, 3, 9, 11, 22, 33),
                        PredstavaId = 24,
                        UplataId = 5
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 8,
                        DatumUplate = new DateTime(2022, 3, 10, 11, 22, 33),
                        PredstavaId = 19,
                        UplataId = 5
                    },
                    new PredstavaUplata
                    {
                        PredstavaUplataId = 9,
                        DatumUplate = new DateTime(2022, 3, 11, 11, 22, 33),
                        PredstavaId = 26,
                        UplataId = 4
                    }
                );
            #endregion

            #region Dodavanje predstava kupac
            modelBuilder.Entity<PredstavaKupac>().HasData(
                new PredstavaKupac
                {
                    PredstavaKupacId = 6,
                    Ocjena = 8,
                    PredstavaId = 3,
                    KupacId = 8
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 7,
                    Ocjena = 4.9,
                    PredstavaId = 1,
                    KupacId = 8
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 13,
                    Ocjena = 6,
                    PredstavaId = 1,
                    KupacId = 12
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 14,
                    Ocjena = 5,
                    PredstavaId = 6,
                    KupacId = 8
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 15,
                    Ocjena = 8,
                    PredstavaId = 25,
                    KupacId = 16
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 16,
                    Ocjena = 3.7,
                    PredstavaId = 29,
                    KupacId = 16
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 17,
                    Ocjena = 8,
                    PredstavaId = 23,
                    KupacId = 16
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 19,
                    Ocjena = 10,
                    PredstavaId = 1,
                    KupacId = 8
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 21,
                    Ocjena = 9,
                    PredstavaId = 1,
                    KupacId = 16
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 22,
                    Ocjena = 8,
                    PredstavaId = 24,
                    KupacId = 12
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 23,
                    Ocjena = 7,
                    PredstavaId = 30,
                    KupacId = 16
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 24,
                    Ocjena = 6.5,
                    PredstavaId = 29,
                    KupacId = 14
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 25,
                    Ocjena = 7.7,
                    PredstavaId = 26,
                    KupacId = 15
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 26,
                    Ocjena = 7,
                    PredstavaId = 25,
                    KupacId = 13
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 28,
                    Ocjena = 4,
                    PredstavaId = 23,
                    KupacId = 14
                },
                new PredstavaKupac
                {
                    PredstavaKupacId = 29,
                    Ocjena = 5,
                    PredstavaId = 19,
                    KupacId = 16
                }
            );
            #endregion

            #region Dodavanje dokumenata
            modelBuilder.Entity<Dokument>().HasData(
                new Dokument
                {
                    DokumentId = 1,
                    NazivDokumenta = "Antigona",
                    Sadrzaj = File.ReadAllBytes("antigona.jpg"),
                    FileName = "antigona.jpg"
                }
            );
            #endregion
        }
    }
}