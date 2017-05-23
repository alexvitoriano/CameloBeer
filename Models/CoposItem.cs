using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameloBeer.Models
{
	public class CoposItem
	{
		public const string PILSNER = "PILSNER";
		public const string LAGER = "LAGER";
		public const string CALDERETA = "CALDERETA";
		public const string PINT = "PINT";
		public const string WEIZEN = "WEIZEN";
		public const string TULIPA="TULIPA";
		public const string CALICE="CÁLICE";
		public const string FLAUTA="FLAUTA";
		public const string CANECA="CANECA";
		public const string MASS="MASS";
		public const string YARD="YARD";
		public const string TACA="TAÇA";
		public const string TUMBLER="TUMBLER";
		public const string CILINDRICO="CILÍNDRICO";
		public const string CONHAQUE="CONHAQUE";

		public CoposItem ()
		{
			ItemName = ImageSrc = Description = string.Empty;
		}

		public string ItemName { get; set; }

		public string ImageSrc { get; set; }

		public string Summary { get; set; }

		public string Description { get; set; }

		public static CoposItem CreateCopoItem(string catalogItem)
		{
			CoposItem ci = null;

			switch (catalogItem) {
			case PILSNER:
				ci = new CoposItem () {
					ItemName = PILSNER,
					ImageSrc = "pilsner.jpg",
					Summary = "PILSNER",
					Description = "Nós, brasileiros, o chamamos popularmente de 'tulipa'. Ideal para as cervejas dos tipos Pilsen. Possibilita a formação de um bom creme e direciona o aroma do lúpulo para o nariz. Mas não confunda com o copo de Lager, que também são muito usados para chope aqui no Brasil: o Pilsner tem a boca mais larga, enquanto o de Lager tem a boca levemente fechada.",
				};
				break;

			case LAGER:
				ci = new CoposItem () {
					ItemName = LAGER,
					ImageSrc = "lager.jpg",
					Summary = "LAGER",
					Description = "Facilmente encontrados no Brasil, são os tradicionais copos de chope, o qual erroneamente chamamos de tulipa. A diferenca é que a tulipa tem a boca mais aberta, um pé mais fino, longo e elevado.",
				};
				break;

			case CALDERETA:
				ci = new CoposItem () {
					ItemName = CALDERETA,
					ImageSrc = "caldereta.jpg",
					Summary = "CALDERETA",
					Description = "Comumente visto servindo chope em algumas choperias, o caldereta é versátil e pode ser utilizado para English e American Ales e também para algumas lagers escuras e IPAs. Por comportar um volume um pouco acima de 300ml, é uma alternativa mais adequada do que outros copos genéricos, portanto uma boa opção para se ter em casa quando não se pode ter os diversos estilos recomendados. Também leva o nome de Shaker.",
				};
				break;

			case PINT:
				ci = new CoposItem () {
					ItemName = PINT,
					ImageSrc = "pint.jpg",
					Summary = "PINT",
					Description = "Para os mais curiosos, o anel dos Nonick Pints foram encorporados por volta de 1960 para facilitar o empilhamento de copos, evitando que eles ficassem presos e quebrassem.",
				};
				break;

			case WEIZEN:
				ci = new CoposItem () {
					ItemName = WEIZEN,
					ImageSrc = "weiss.jpg",
					Summary = "WEIZEN",
					Description = "Como o próprio nome já diz, é ideal para cervejas do tipo Weiss, as de trigo. Permite que se admire o corpo e a cor da cerveja, bem como a expansão do creme. E como são altos, possibilitam que todo o conteúdo de garrafas de 500ml sejam colocados no copo, incluindo o fundo com as leveduras, e ainda sobre espaço para a espuma, como manda a tradição do estilo.",
				};
				break;

			case TULIPA:
				ci = new CoposItem () {
					ItemName = TULIPA,
					ImageSrc = "tulipa.jpg",
					Summary = "TULIPA",
					Description = "Ideal para cervejas que possuem bastante creme, como a Duvel e outras Strong Ales belgas. O desenho é baixo e elegante, permitindo também observar a evolução da espuma. Não confundir com o que chamamos aqui no Brasil de Tulipa, que na verdade é um copo Pilsner. A Tulipa parece mais com uma taça de conhaque, porém com a boca do copo virada para fora.",
				};
				break;

			case CALICE:
				ci = new CoposItem () {
					ItemName = CALICE,
					ImageSrc = "calice.jpg",
					Summary = "CALICE",
					Description = "Na Bélgica é chamado de Goblet, e lembra a flor do mesmo nome. Ideais para as grandes trapistas belgas. São muito bonitos, às vezes ostentando dourado na borda. São desenhados para manter íntegro o creme, bem como proporcionar maior percepção do aroma. Também podem ser usados com os estilos Dubbel, Tripel e Quadrupel. Váriações de formato são encontradas com os nomes de Bolleke (copos da Leffe e Westmalle) e Trapist (copo da LaTrappe), mas todos compartilham características como bocas largas e um pezinho alongado.",
				};
				break;

			case FLAUTA:
				ci = new CoposItem () {
					ItemName = FLAUTA,
					ImageSrc = "flauta.jpg",
					Summary = "FLAUTA",
					Description = "Em forma de flauta, são mais usados para beber espumantes e champagnes, mas são ideais para cervejas do tipo Faro, Lambic, Gueuze ou as champegnoises, como a belga Deus e a brasileira Lust. O fato de serem esguios possibilita que o creme demore mais para se dissipar, mantendo as qualidades da cerveja no copo.",
				};
				break;

			case CANECA:
				ci = new CoposItem () {
					ItemName = CANECA,
					ImageSrc = "caneca.jpg",
					Summary = "CANECA",
					Description = "Muito usada para servir chope ou cervejas vendidas na pressão. Podem ter vários tamanhos e formatos, mas normalmente são robustos, de vidro grosso, e algumas têm até apoio para o polegar na alça, para ajudar com o peso do copo+cerveja. Também podem ser de cerâmica e metal, mas para degustações, prefira as de vidro mesmo, maior garantia de não influenciar no sabor da cerveja.",
				};
				break;

			case MASS:
				ci = new CoposItem () {
					ItemName = MASS,
					ImageSrc = "mass.jpg",
					Summary = "MASS",
					Description = "É o típico canecão alemão de 1 litro, ideal para grandes e festeiros bebedores, daqueles que adoram brindar a cada minuto. Devem seu sucesso à quantidade de cerveja que podem conter. Também chamado de Seidel.",
				};
				break;

			case YARD:
				ci = new CoposItem () {
					ItemName = YARD,
					ImageSrc = "yard.jpg",
					Summary = "YARD",
					Description = "Parece um tubo de laboratório, sem pé, o que demanda um suporte de madeira caso quem estiver usando-o não queira ficar segurando-o o tempo todo. Ficou famoso por ser usado e recomendado pela Pauwel Kwak.",
				};
				break;

			case TACA:
				ci = new CoposItem () {
					ItemName = TACA,
					ImageSrc = "taca.jpg",
					Summary = "TACA",
					Description = "Não estão ligadas a nenhum estilo em específico, mas são cada dia mais usados com cerveja, seja pela elegância que confere, seja pela ergonomia que oferecem. Taças de vinho também vêm sendo utilizadas em degustações, principalmente aquelas altas e largas e as do tipo ISO, aquelas menores para degustação. \nTambém podem entrar nesta categoria os copos do tipo Pokal, ou Footed Glass.",
				};
				break;

			case TUMBLER:
				ci = new CoposItem () {
					ItemName = TUMBLER,
					ImageSrc = "tumbler.jpg",
					Summary = "TUMBLER",
					Description = "Copo utilizado para as cervejas do tipo witbier, com o a Hoegaarden. Como estas cervejas não formam muito creme, o copo não precisa ter a boca fechada. Robustos e pesados, também facilitam a vida dos bares por serem mais difíceis de serem quebrados, por isso não é incomum serem usados para servir coquetéis, refrigerante e chá gelado.",
				};
				break;

			case CILINDRICO:
				ci = new CoposItem () {
					ItemName = CILINDRICO,
					ImageSrc = "cilindrico.jpg",
					Summary = "CILINDRICO",
					Description = "Copos cilíndricos normalmente são usados para cervejas Kölsh e Altbier. Porém, podem ser recomendadas pelos fabricantes em outros estilos, com por exemplo algumas fruit-beers. Permitem uma boa formação de espuma, porém não ajudam muito no desenvolvimento do aroma. Podem aparecer com outros nomes, como Stange, Stick (vareta) ou Collins.",
				};
				break;

			case CONHAQUE:
				ci = new CoposItem () {
					ItemName = CONHAQUE,
					ImageSrc = "snifter.jpg",
					Summary = "CONHAQUE",
					Description = "Copos como os usados para conhaque são indicados para Barley Wines, Eisbock e Imperial Stouts, ou seja, cervejas fortes. São ótimos para capturar os aromas, permitindo agitar a cerveja em movimentos rotativos leves, sem muito risco de que a cerveja transborde o limite do copo. Também ajudam na manutenção de espuma, permitindo grandes goles sem que muito dela acabe entrando em contato com o rosto de quem bebe. Também chamados de Snifter.",
				};
				break;
			}
			return ci;
		}

	}
}
