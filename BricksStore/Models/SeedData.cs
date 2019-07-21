using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BricksStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Bugatti Chiron",
                        Description = "Model Bugatti Chiron w skali 1:8",
                        Category = "Technic",
                        Price = 1300
                    },
                    new Product
                    {
                        Name = "Koparka kołowa",
                        Description = "Model kombajnu",
                        Category = "Technic",
                        Price = 850
                    },
                    new Product
                    {
                        Name = "Taj Mahal",
                        Description = "Makieta świątyni Taj Mahal",
                        Category = "Creator",
                        Price = 1800
                    },
                    new Product
                    {
                        Name = "Millennium Falcon",
                        Description = "Model Sokoła Milenium",
                        Category = "Star Wars",
                        Price = 2800
                    },
                    new Product
                    {
                        Name = "Batman i Joker",
                        Description = "Figurki Brickheadz Batmana i Jokera",
                        Category = "Brickheadz",
                        Price = 89.99M
                    },
                    new Product
                    {
                        Name = "Anna i Olaf",
                        Description = "Figurki Anny i Olafa z filmu Frozen",
                        Category = "Brickheadz",
                        Price = 42.99M
                    },
                    new Product
                    {
                        Name = "Druga Strona",
                        Description = "Fani wyprodukowanego przez stację Netflix światowego przeboju z pewnością docenią wierność detali tego wyjątkowego, kolekcjonerskiego modelu LEGO® Stranger Things z zestawu 75810 Druga Strona. Ten solidny model z klocków obraca się: jedna jego część należy do realnego świata, a druga do Drugiej Strony. Instrukcje do modelu przygotowano tak, by budowanie mogło być świetną zabawą w gronie rodziny lub przyjaciół. W domu Byersów jest sypialnia Willa, salon i jadalnia. W wersji z innego wymiaru — Drugiej Strony — są te same pomieszczenia, ale całość jest mroczna, podniszczona i obrośnięta winoroślą. Zupełnie jak w serialu! W pudełku znajdziesz 8 figurek serialowych postaci, a do każdej z nich są dołączone akcesoria. Zestaw będzie więc doskonałym prezentem dla każdego fana, który chce pokazać światu swoją fascynację „Stranger Things”.",
                        Category = "Stranger Things",
                        Price = 899.99M
                    },
                    new Product
                    {
                        Name = "Aston Martin DB5 Jamesa Bonda",
                        Description = "Zdobądź licencję na budowanie fantastycznego zestawu LEGO® Creator Expert 10262 Aston Martin DB5 Jamesa Bonda™. Ta imponująca replika z mnóstwem autentycznych szczegółów i działających gadżetów doskonale oddaje elegancję i ponadczasową finezję kultowego samochodu sportowego agenta 007 z 1964 r. ",
                        Category = "Creator",
                        Price = 699.99M
                    },
                    new Product
                    {
                        Name = "Rexcelsior",
                        Description = "Dzieci z radością zbudują model 70839 Rexcelsior i wcielą się w popularne postacie z filmu LEGO® PRZYGODA 2™ podczas pełnej przygód wyprawy przez galaktykę. Zabawkowy statek kosmiczny LEGO ma otwierane drzwi i podnoszone dachy, co ułatwia zabawę w środku. W szczegółowym wnętrzu znajduje się kokpit dla dwóch minifigurek oraz różne pomieszczenia i schowki do zwiedzania w mikroskali. Uchwyt z tyłu statku ma przełącznik służący do uruchamiania szybkostrzelnego działka na sześć sprężynowych rakiet. Miłośnikom filmu LEGO PRZYGODA 2 spodoba się odgrywanie ulubionych scen i wymyślanie własnych historii z udziałem minifigurek Rexa i Emmeta oraz mikrofigurek, mikroraptorów i mikromodeli, które można ustawić we wnętrzu Rexcelsiora!",
                        Category = "Lego Movie",
                        Price = 709.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
