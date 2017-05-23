using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameloBeer.Models
{
	public class CatalogItem
	{
		public const string ITEM_Cerveja1 = "LAGER";
		public const string ITEM_Cerveja2 = "PILSNER";
		public const string ITEM_Cerveja3 = "AMERICAN LAGER";
		public const string ITEM_Cerveja4 = "BOCK";
		public const string ITEM_Cerveja5 = "ENGLISH PALE ALE";
		public const string ITEM_Cerveja6 = "STOUT";
		public const string ITEM_Cerveja7 = "AMERICAN ALE";
		public const string ITEM_Cerveja8 = "PORTER";
		public const string ITEM_Cerveja9 = "INDIA PALE ALE";
		public const string ITEM_Cerveja10 = "RED ALE";
		public const string ITEM_Cerveja11 = "BELGIAN STRONG ALE";

		public CatalogItem()
		{
			ItemName = ImageSrc = Description = string.Empty;
			SuggestedPrice = 0;
		} //end ctor

		public string ItemName { get; set; }

		public string ImageSrc { get; set; }

		public int SuggestedPrice { get; set; }

		public string Summary { get; set; }

		public string Description { get; set; }


		public static CatalogItem CreateCatalogItem(string catalogItem)
		{
			CatalogItem ci = null;

			switch (catalogItem)
			{
			case ITEM_Cerveja1:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja1,
					ImageSrc = "lager1.png",
					SuggestedPrice = 200,
					Summary = ITEM_Cerveja1,
					Description = "São cervejas de baixa fermentação (5ºC – 14ºC)  e armazenadas em temperatura baixa. O termo Lager em si é derivado da palavra alemã “lagern” que significa “armazenar”. Representam o tipo de cerveja mais consumido mundialmente, com mais de 90% do mercado. Devido ao tipo de fermento utilizado e à baixa temperatura de fermentação, as leveduras tendem a se acumular no fundo do tanque de fermentação.",
				};
				break;

			case ITEM_Cerveja2:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja2,
					ImageSrc = "pilsner1.png",
					SuggestedPrice = 800,
					Summary = ITEM_Cerveja2,
					Description = "A mais conhecida variedade das cervejas lager. Foi concebida na cidade de Pils (Plzeň), na República Tcheca e é na atualidade uma das cervejas mais vendidas globalmente. É clara, dourada, com um delicado porém presente sabor de lúpulo.",
				};
				break;

			case ITEM_Cerveja3:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja3,
					ImageSrc = "american.png",
					SuggestedPrice = 1500,
					Summary = ITEM_Cerveja3,
					Description =  "Grande sucesso nos Estados Unidos, se trata de uma cerveja leve e refrescante. Ótimas para serem servidas bem geladas em dias ensolarados. Apesar da maioria das cervejas populares brasileiras se intitularem Pilsen (Pilsner), na verdade elas são do tipo American Lager.",
				};
				break;

			case ITEM_Cerveja4:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja4,
					ImageSrc = "bock.png",
					SuggestedPrice = 350,
					Summary =  ITEM_Cerveja4,
					Description = "Tipicamente avermelhadas, mas também encontradas na cor marrom, a cerveja Bock é uma cerveja com alto teor alcoólico, chegando à 14º. Com sabor de malte pronunciado, ela é mais comumente consumida no Brasil durante o inverno. Seu nome faz referência à cidade onde foi criada, Einbeck, na Alemanha.",
				};
				break;

			case ITEM_Cerveja5:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja5,
					ImageSrc = "english.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja5,
					Description = "Como o próprio nome adianta, as cervejas deste tipo são muito populares na terra da rainha, onde é conhecida como Bitter (amargo). São cervejas claras devido ao tipo de malte utilizado, com amargor e corpo moderados. Geralmente este tipo de cerveja produz pouco colarinho, devido sua baixa carbonatação.",
				};
				break;

			case ITEM_Cerveja6:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja6,
					ImageSrc = "stout.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja6,
					Description = "As cervejas Stout possuem forte sabor de chocolate, café e malte torrado. Possuem cor escura/negra opaca e alto teor alcoólico (8-12%).",
				};
				break;

			case ITEM_Cerveja7:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja7,
					ImageSrc = "americanale.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja7,
					Description = "A maioria das cervejas American Ale possuem um sabor de lúpulo de intensidade moderada a forte. Outra característica bastante comum nesta cerveja é a presença de um tom cítrico em seu paladar. Sua cor varia do dourado límpido (American Pale Ale) ao âmbar (American Ambar Ale). É uma cerveja considerada refrescante e com bom suporte de malte em sua receita.",
				};
				break;

			case ITEM_Cerveja8:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja8,
					ImageSrc = "porter.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja8,
					Description = "As cervejas Porter são muito parecidas com as cervejas Stout e algumas vezes são até confundidas entre si. As principais diferenças são que a Porter possuem um sabor mais suave e graduação alcoólica menor.",
				};
				break;

			case ITEM_Cerveja9:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja9,
					ImageSrc = "ipa.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja9,
					Description = "As cervejas do IPA possuem um marcante sabor de lúpulo que é ao mesmo tempo intenso e refrescante. Criada pelos ingleses para as viagens à Índia, a grande adição de lúpulo servia para conservar a cerveja por longos períodos no mar.",
				};
				break;

			case ITEM_Cerveja10:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja10,
					ImageSrc = "redale.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja10,
					Description = "Sua cor vermelha é originada pela utilização do malte tostado em seu processo de preparação. São cervejas suaves e de sabor equilibrado, partindo de tons adocicados até um amargor moderado.",
				};
				break;

			case ITEM_Cerveja11:
				ci = new CatalogItem()
				{
					ItemName = ITEM_Cerveja11,
					ImageSrc = "belgian.png",
					SuggestedPrice = 2500,
					Summary = ITEM_Cerveja11,
					Description = "Este estilo de cerveja podem ser encontradas tanto com coloração clara (Belgian Golden Strong Ale), como escura (Belgian Dark Strong Ale). Tem sabor complexo, com forte tom frutado, devido à grande presença de ésteres liberados em seu processo de fermentação. Alta carbonatação e sustentação do sabor pelo malte são outras características deste tipo de cerveja.",
				};
				break;
			}

			return ci;
		}

	}
}

