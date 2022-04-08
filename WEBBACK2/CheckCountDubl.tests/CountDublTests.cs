using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckCountDubl.Tests
{
    [TestClass]
    public class CountDublTests
    {
        [TestMethod]



        [DataTestMethod]
        [DataRow("exilic", 1)]
        [DataRow("aaaacccccccccbb", 3)]
        [DataRow("momentaneously", 4)]
        [DataRow("hydramnios", 0)]
        [DataRow("a", 0)]
        [DataRow("AAAAAbb44", 3)]
        [DataRow("iamuncous", 1)]
        [DataRow("BINDOREE", 1)]
        [DataRow("BINDOREe", 1)]
        [DataRow("hErpe123123tography", 7)]
        [DataRow("mA1thematics", 3)]
        [DataRow("Uncopyrightable", 0)]
        [DataRow("Euouae", 2)]
        [DataRow("1a2b3c4d56789_1a2b3c4d67890", 12)]
        [DataRow("1a2b3c4d5679zg_1a2b3c467890777774z", 11)]
        [DataRow("EtharumquidemrerumfacilisestetexpeditadistinctioquiineavoluptatevelitessequamnihilmolestiaeconsequaturvelillumvelitessecillumdoloreeufugiatnullapariaturwSedutperspiciatisnamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatvelitessecillumdoloreeufugiatnullapariaturwSedutperspiciatisconsecteturadipiscingelitnisiutaliquidexeacommodiconsequaturEtharumquidemrerumfacilisestetexpeditadistinctioquisnostrumexercitationemullamcorporissuscipitlaboriosamseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaAtvero", 22)]
        [DataRow("DuisauteiruredolorinreprehenderitinvoluptatequiblanditiispraesentiumvoluptatumdelenitiatquecorruptiquosdoloresetquasmolestiasexcepturisintquisnostrudexercitationullamcolaborisnisiutaliquipexeacommodoconsequatItaqueearumrerumhicteneturasapientedelectusquiineavoluptatevelitessequamnihilmolestiaeconsequaturvelillumvelitessecillumdoloreeufugiatnullapariaturExcepteursintoccaecatcupidatatnonproidentnamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatnisiutaliquidexeacommodiconsequaturLoremipsumdolorsitametconsecteturadipiscingelitseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaExcepteursintoccaecatcupidatatnonproidentquiineavoluptatevelitessequamnihilmolestiaeconsequaturvelillumnisiutaliquidexeacommodiconsequaturUtenimadminimveniamquisnostrumexercitationemullamcorporissuscipitlaboriosamvelitessecillumdoloreeufugiatnullapariaturTemporibusautemquibusdametautofficiisdebitisautrerumnecessitatibussaepeevenietquisnostrumexercitationemullamcorporissuscipitlaboriosamutetvoluptatesrepudiandaesintetmolestiaenonrecusandaeNemoenimipsamvoluptatemnamliberotemporecumsolutanobisesteligendioptiocumquenihil", 21)]
        [DataRow("UtenimadminimaveniamconsecteturadipiscingelitvelitessecillumdoloreeufugiatnullapariaturQuisautemveleumiurereprehenderitquiblanditiispraesentiumvoluptatumdelenitiatquecorruptiquosdoloresetquasmolestiasexcepturisintseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaEtharumquidemrerumfacilisestetexpeditadistinctionamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatvelitessecillumdoloreeufugiatnullapariaturTemporibusautemquibusdametautofficiisdebitisautrerumnecessitatibussaepeevenietquisnostrumexercitationemullamcorporissuscipitlaboriosamquidoloremeumfugiatquovoluptasnullapariaturItaqueearumrerumhicteneturasapientedelectusquiblanditiispraesentiumvoluptatumdelenitiatquecorruptiquosdoloresetquasmolestiasexcepturisintquisnostrudexercitationullamcolaborisnisiutaliquipexeacommodoconsequatSedutperspiciatisquiblanditiispraesentiumvoluptatumdelenitiatquecorruptiquosdoloresetquasmolestiasexcepturisintquidoloremipsumquiadolorsitametconsecteturadipiscivelitsedquianonnumquameiusmoditemporainciduntutlaboreetdoloremagnamaliquamquaeratvoluptatemUtenimadminimveniamnamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatobcaecaticupiditatenonprovidentsimiliquesuntinculpaquiofficiadeseruntmollitiaanimiidestlaborumetdolorumfugaTemporibusautemquibusdametautofficiisdebitisautrerumnecessitatibussaepeevenietquiblanditiispraesentiumvoluptatumdelenitiatquecorruptiquosdoloresetquasmolestiasexcepturisintquaeabilloinventoreveritatisetquasiarchitectobeataevitaedictasuntexplicaboDuisauteiruredolorinreprehenderitinvoluptatequiavoluptassitaspernaturautoditautfugitsedquiaconsequunturmagnidoloreseosquirationevoluptatemsequinesciuntnequeporroquisquamestseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaExcepteursintoccaecatcupidatatnonproidentundeomnisistenatuserrorsitvoluptatemaccusantiumdoloremquelaudantiumtotamremaperiameaqueipsaquidoloremeumfugiatquovoluptasnullapariaturSedutperspiciatisconsecteturadipiscingelitsuntinculpaquiofficiadeseruntmollitanimidestlaborumQuisautemveleumiurereprehenderitundeomnisistenatuserrorsitvoluptatemaccusantiumdoloremquelaudantiumtotamremaperiameaqueipsaquidoloremipsumquiadolorsitametconsecteturadipiscivelitsedquianonnumquameiusmoditemporainciduntutlaboreetdoloremagnamaliquamquaeratvoluptatemEtharumquidemrerumfacilisestetexpeditadistinctioquisnostrumexercitationemullamcorporissuscipitlaboriosamseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaTemporibusautemquibusdametautofficiisdebitisautrerumnecessitatibussaepeevenietconsecteturadipiscingelitfacerepossimusomnisvoluptasassumendaestomnisdolorrepellendusNemoenimipsamvoluptatemquiineavoluptatevelitessequamnihilmolestiaeconsequaturvelillumobcaecaticupiditatenonprovidentsimiliquesuntinculpaquiofficiadeseruntmollitiaanimiidestlaborumetdolorumfugaLoremipsumdolorsitametnamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatquaeabilloinventoreveritatisetquasiarchitectobeataevitaedictasuntexplicaboSedutperspiciatisquisnostrumexercitationemullamcorporissuscipitlaboriosamquisnostrudexercitationullamcolaborisnisiutaliquipexeacommodoconsequatSedutperspiciatisnamliberotemporecumsolutanobisesteligendioptiocumquenihilimpeditquominusidquodmaximeplaceatfacerepossimusomnisvoluptasassumendaestomnisdolorrepellendusExcepteursintoccaecatcupidatatnonproidentquiavoluptassitaspernaturautoditautfugitsedquiaconsequunturmagnidoloreseosquirationevoluptatemsequinesciuntnequeporroquisquamestvelitessecillumdoloreeufugiatnullapariaturItaqueearumrerumhicteneturasapientedelectusquisnostrumexercitationemullamcorporissuscipitlaboriosamutautreiciendisvoluptatibusmaioresaliasconsequaturautperferendisdoloribusasperioresrepellatDuisauteiruredolorinreprehenderitinvoluptateconsecteturadipiscingelitquisnostrudexercitationullamcolaborisnisiutaliquipexeacommodoconsequatNemoenimipsamvoluptatemquisnostrumexercitationemullamcorporissuscipitlaboriosamseddoeiusmodtemporincididuntutlaboreetdoloremagnaaliquaEtharumquidemrerumfacilisestetexpeditadistinctioquiavoluptassitaspernaturautodit", 21)]


        public void Check(string str, int expected)
        {
            CountDubl c = new CountDubl();
            int actual = c.Count(str);

            Assert.AreEqual(expected, actual);
        }

    }
}