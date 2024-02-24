Episode epi1 = new Episode(1, "tecnicas de facilitacao", 45);
epi1.AddGuests("Maria");
epi1.AddGuests("Joao");

Episode epi2 = new Episode(2,"Tecnicas de ninjutsu", 50);
epi2.AddGuests("Andre");
epi2.AddGuests("Marcelo");

Podcast podcast = new Podcast("ALura", "SoftEng na Veia");
podcast.AddEpisode(epi2);
podcast.AddEpisode(epi1);
podcast.Description();