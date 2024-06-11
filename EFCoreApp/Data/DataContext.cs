﻿using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Data
{
	public class DataContext:DbContext
	{
		public DbSet<Kurs> Kurslar => Set<Kurs>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
		public DbSet<KursKayit> KursKayitlari => Set<KursKayit>();
	}

	// code-first => entity, dbcontext => database (sqlite)
	// database-first => sql server
}
