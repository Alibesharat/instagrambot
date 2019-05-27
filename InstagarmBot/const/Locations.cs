using System.ComponentModel.DataAnnotations;

namespace InstagarmBot
{
    public enum Locations
{

    [Display(Name = "البرز خوزستان", ShortName = " 567248691")]
    Alborz_Khuzestan_Iran,
    [Display(Name = "کردان  مرکزی", ShortName = " 509176516")]
    Kurdan_Markazī_Iran,
    [Display(Name = "البرز مرکزی", ShortName = " 320229684")]
    Alborz_Markazi_Iran,
    [Display(Name = "دبیرستان البرز حاده قدیم شمران نزدیک پارک کوروش", ShortName = " 242899695")]
    Alborz_High_School_Jadeh_ghadim_e_Shemran_near_Park_e_Koorosh,
    [Display(Name = "استان البرز", ShortName = " 636518813")]
    Alborz_Province,
    [Display(Name = "آتشگاه مرکزی", ShortName = " 316179720")]
    Atashgah_Markazī_Iran,
    [Display(Name = "اردبیل", ShortName = " 243740461")]
    Ardabil_Iran,
    [Display(Name = "استان اردبیل", ShortName = " 806345840")]
    Ardabil_Province,
    [Display(Name = "بوشهر", ShortName = " 221517792")]
    Bushehr,
    [Display(Name = "استان بوشهر", ShortName = " 829893454")]
    Bushehr_Province,
    [Display(Name = "استان فارس", ShortName = " 570046992")]
    Fars_Province,
    [Display(Name = "نورآباد فارس", ShortName = " 235861432")]
    Nurabad_Fars,
    [Display(Name = "استان گیلان", ShortName = " 793553196")]
    Gilan_Province,
    [Display(Name = "استان گلستان", ShortName = " 241226525")]
    Golestan_Province,
    [Display(Name = "گلستان گلستان ایران", ShortName = " 571467097")]
    Golestan_Golestān_Iran,
    [Display(Name = "گلستان ایران", ShortName = " 245042459")]
    Golestan_Iran,
    [Display(Name = "گلستان تهران", ShortName = " 222007523")]
    Golestan_Tehran_Iran,
    [Display(Name = "گلستان بوشهر", ShortName = " 1017124695")]
    Golestan_Bushehr_Iran,
    [Display(Name = "گلستان زنجان", ShortName = " 1020086963")]
    Golestan_Zanjan_Iran,
    [Display(Name = "استان همدان", ShortName = " 997247021")]
    Hamadan_Province,
    [Display(Name = "همدان", ShortName = " 648764188")]
    Hamedan,
    [Display(Name = "استان هرمزگان", ShortName = " 674057327")]
    Hormozgan_Province,
    [Display(Name = "بندرعباس", ShortName = " 730668870")]
    Bandar_Abbas_Hormozgan_Iran,
    [Display(Name = "بندرعباس", ShortName = " 213573215")]
    Bandar_E_Abbas_Hormozgan_Iran,
    [Display(Name = "قشم", ShortName = " 214991854")]
    Qeshm_Hormozgan_Iran,
    [Display(Name = "بندرکنگ", ShortName = " 236582201")]
    Bandar_E_Kong_Hormozgan_Iran,
    [Display(Name = "قوابندی هرمزگان", ShortName = " 241559398")]
    Gavbandi_Hormozgan_Iran,
    [Display(Name = "بندر خمیر هرمزگان", ShortName = " 215088335")]
    Bandar_E_Khamir_Hormozgan_Iran,
    [Display(Name = "کیش", ShortName = " 212893863")]
    Kish_Iran,
    [Display(Name = "ابوموسی", ShortName = " 547731320")]
    Abu_Musa_Hormozgan_Iran,
    [Display(Name = "بندلنگه", ShortName = " 237817792")]
    Bandar_E_Lengeh_Hormozgan_Iran,
    [Display(Name = "شاهرود", ShortName = " 567987820")]
    Shahrood,
    [Display(Name = "دانشگاه صنعتی شاهرود", ShortName = "432931911")]
    Shahrood_University_of_Technology,
    [Display(Name = "رمکان هرمزگان", ShortName = " 256935917")]
    Ramkan_Hormozgan_Iran,
    [Display(Name = "ده بارز هرمزگان", ShortName = " 756571810")]
    Deh_Barez_Hormozgan_Iran,
    [Display(Name = "کمشک هرمزگان", ShortName = " 263392265")]
    Kemeshk_Hormozgan_Iran,
    [Display(Name = "جزیره هرمزگان", ShortName = " 276358973")]
    Gezir_Hormozgan_Iran,
    [Display(Name = "هلر هرمزگان", ShortName = " 323748783")]
    Holor_Hormozgan_Iran,
    [Display(Name = "ایلام", ShortName = " 216569283")]
    Ilam_Iran,
    [Display(Name = "استا ایلام", ShortName = " 1028094979")]
    Ilam_Province,
    [Display(Name = "اضفهان", ShortName = " 213992789")]
    Esfahan_Iran,
    [Display(Name = "استان اصفهان", ShortName = " 808768203")]
    Isfahan_Province,
    [Display(Name = "کرمان", ShortName = " 217412913")]
    Kerman_Iran,
    [Display(Name = "استان کرمان", ShortName = " 781654988")]
    Kerman_Province,
    [Display(Name = "کرمانشاه", ShortName = " 234878921")]
    Kermanshah_Iran,
    [Display(Name = "استان کرمانشاه", ShortName = " 1025699584")]
    Kermanshah_Province,
    [Display(Name = "کرمان مازندران", ShortName = " 794030448")]
    Kerman_Mazandaran_Iran,
    [Display(Name = "خوزستان", ShortName = " 677172239")]
    Khuzestan_Province,
    [Display(Name = "ایذه", ShortName = " 250410734")]
    Iz̄Eh_Khuzestan_Iran,
    [Display(Name = "استان کردستان", ShortName = " 675775885")]
    Kurdistan_Province,
    [Display(Name = "دانشگاه کردستان هولر", ShortName = " 960509958")]
    University_of_Kurdistan_Hewler,
    [Display(Name = "اربیل عراق", ShortName = " 235702528")]
    Iraq_Kurdistan_Irbil_Iraq,
    [Display(Name = "استان لرستان", ShortName = " 682148249")]
    Lorestan_Province,
    [Display(Name = "الیگودرز", ShortName = " 292092954")]
    Aligudarz_Lorestan_Iran,
    [Display(Name = "قزوین", ShortName = " 235303520")]
    Qazvin,
    [Display(Name = "قم", ShortName = " 222818506")]
    Qom_Iran,
    [Display(Name = "کهک قم", ShortName = " 303638166")]
    Kahak_E_Qom_Markazi_Iran,
    [Display(Name = "سمنان", ShortName = " 234736216")]
    Semnan_Iran,
    [Display(Name = "استان سمنان", ShortName = " 1008059126")]
    Semnan_Province,
    [Display(Name = "بسطام ", ShortName = " 243860628")]
    Bastam_Semnan_Iran,
    [Display(Name = "تهران", ShortName = " 213755156")]
    Tehran_Iran,
    [Display(Name = "استان تهران", ShortName = " 1024536754")]
    Tehran_Province,
    [Display(Name = "دانشگاه تهران", ShortName = " 216952920")]
    University_of_Tehran,
    [Display(Name = "تهرانپارس", ShortName = " 230111197")]
    Tehran_Pars_Tehran_Iran,
    [Display(Name = "زنجان", ShortName = " 251355975")]
    Zanjan_Iran,
    [Display(Name = "استان زنجان", ShortName = " 831608064")]
    Zanjan_Province,
    [Display(Name = "آبادان", ShortName = " 234339864")]
    Abadan_Iran,
    [Display(Name = "اهر", ShortName = " 265394735")]
    Ahar,
    [Display(Name = "اهواز", ShortName = " 223245537")]
    Ahvaz,
    [Display(Name = "آمل", ShortName = " 234454217")]
    Amol,
    [Display(Name = "شهرستان آمل", ShortName = " 217502058")]
    Amol_County,
    [Display(Name = "اندمیشک", ShortName = " 251877094")]
    Andimeshk,
    [Display(Name = "اندیشه", ShortName = " 235139907")]
    Andisheh,
    [Display(Name = "استدیو اندیشه", ShortName = " 527061637")]
    Andisheh_Tv_Studios,
    [Display(Name = "اراک", ShortName = " 250547491")]
    Arak_Iran,
    [Display(Name = "بابل", ShortName = " 222534439")]
    Babol,
    [Display(Name = "بابلسر", ShortName = " 222660558")]
    Babol_Sar_Mazandaran_Iran,
    [Display(Name = "بم", ShortName = " 218096848")]
    Bam_Iran,
    [Display(Name = "گمبرون", ShortName = " 234455167")]
    Gombroon,
    [Display(Name = "بندر انزلی", ShortName = " 214161793")]
    Bandar_e_Anzali,
    [Display(Name = "بانه", ShortName = " 255614739")]
    Baneh,
    [Display(Name = "بانه مرکزی", ShortName = " 672789883")]
    Baneh_Markazi_Iran,
    [Display(Name = "بهبهان", ShortName = " 251680208")]
    Behbahan,
    [Display(Name = "بهبهان خوزستان", ShortName = " 299842786")]
    Behbehan_Khuzestan_Iran,
    [Display(Name = "بیرجند", ShortName = " 244426838")]
    Birjand,
    [Display(Name = "بجنورد", ShortName = " 235524747")]
    Bojnurd,
    [Display(Name = "برازجان", ShortName = " 245155062")]
    Borazjan,
    [Display(Name = "برازجان 2", ShortName = " 205530359866389")]
    Borāzjān,
    [Display(Name = "برازجان فارس ایران", ShortName = " 571360528")]
    Borazjan_Fars_Iran,
    [Display(Name = "بروجرد", ShortName = " 245228202")]
    Borujerd,
    [Display(Name = "بوکان", ShortName = " 235069084")]
    Bukan_Azarbayjan_E_Khavari_Iran,
    [Display(Name = "چابهار", ShortName = " 645255349")]
    Chabahar,
    [Display(Name = "بندر چابهار", ShortName = "238344636")]
    Chabahar_Port,
    [Display(Name = "دزفول", ShortName = " 236196137")]
    Dezful,
    [Display(Name = "درود", ShortName = " 254148252")]
    Dorud,
    [Display(Name = "شهرستان درود", ShortName = " 285384746")]
    Dorud_County,
    [Display(Name = "اسلامشهر", ShortName = " 237455014")]
    Eslamshahr,
    [Display(Name = "فردیس مرکزی", ShortName = " 455528380")]
    Fardis_Markazī_Iran,
    [Display(Name = "فسا", ShortName = " 244453136")]
    Fasa,
    [Display(Name = "فیسل اباد", ShortName = " 248423677")]
    Faisalabad,
    [Display(Name = "گنبد کاووس", ShortName = " 242748960")]
    Gonbad_e_Qabus,
    [Display(Name = "گنبد کاووس گلستان", ShortName = " 245192866")]
    Gonbad_E_Kavus_Golestān_Iran,
    [Display(Name = "گرگان", ShortName = " 213916382")]
    Gorgan_Iran,
    [Display(Name = "ناهارخوران مازندران", ShortName = " 407057118")]
    Nahar_Khoran_Mazandaran_Iran,
   
    [Display(Name = "ایرانشهر", ShortName = " 237976937")]
    Iranshahr,
    [Display(Name = "ایرانشهر کرمان", ShortName = " 967308367")]
    Iranshahr_Kerman_Iran,
    [Display(Name = "فرودگاه ایرانشهر", ShortName = " 1003592844")]
    Iranshahr_Airport,
    [Display(Name = "جیرفت", ShortName = " 323726533")]
    Jiroft,
    [Display(Name = "کمال شهر", ShortName = " 251892391")]
    Kamal_Shahr,
    [Display(Name = "کرج", ShortName = " 218036864")]
    Karaj,
  
    [Display(Name = "کاشان", ShortName = " 4046840")]
    Kashan,
    [Display(Name = "کاشان", ShortName = " 390550528")]
    Kashan_Tehran_Iran,
    [Display(Name = "کاشمر", ShortName = " 213992789")]
    Kashmar,
    [Display(Name = "خمینی شهر", ShortName = " 265756329")]
    Khomeynishahr_Esfahan_Iran,
    [Display(Name = "شهرستان خمینی شهر", ShortName = " 272631503")]
    Khomeyni_Shahr_County,
    [Display(Name = "دانشگاه صنعتی اصفهان", ShortName = " 235103062")]
    Isfahan_University_of_Technology,
    [Display(Name = "خرم آباد", ShortName = " 236910577")]
    Khorramabad,
    [Display(Name = "خرم اباد ایران", ShortName = " 379540403")]
    Khorramabad_Iran,
    [Display(Name = "خرمشهر", ShortName = " 245019670")]
    Khorramshahr,
    [Display(Name = "مهمره", ShortName = " 110336948988259")]
    Mohammerah,
    [Display(Name = "خوی", ShortName = " 234846249")]
    Khoy,
    [Display(Name = "لاهیجان", ShortName = " 215195616")]
    Lahijan,
    [Display(Name = "مهاباد", ShortName = " 218258649")]
    Mahabad_Iran,
    [Display(Name = "ملارد", ShortName = " 297625770")]
    Malard_Markazī_Iran,
   
    [Display(Name = "ملارد مرکزی", ShortName = " 1014775378")]
    Malard_Markazi_Iran,
    [Display(Name = "شهرستان ملارد", ShortName = " 257447664")]
    Malard_County,
   
    [Display(Name = "ملایر", ShortName = " 236898258")]
    Malayer,
    [Display(Name = "مراغه", ShortName = " 234810235")]
    Maragheh,
    [Display(Name = "مرند", ShortName = " 244041264")]
    Marand,
  
    [Display(Name = "مزیوان", ShortName = " 243725826")]
    Marivan,

    [Display(Name = "مرو دشت", ShortName = " 240863954")]
    Marvdasht,
    [Display(Name = "مرو دشت فارس", ShortName = " 288681260")]
    Marvdasht_Fars_Iran,
    [Display(Name = "ابگارم مرود دشت", ShortName = " 673799009345040")]
    Abgarm_Marvdasht,
    [Display(Name = "جشنیان مرودشت", ShortName = " 1000583573")]
    Jeshnian_Marvdasht,
    [Display(Name = "کرهی مرودشت", ShortName = " 209069002625081")]
    Korrehi_Marvdasht,
    [Display(Name = "مشهد", ShortName = " 220592830")]
    Mashhad_Iran,
    [Display(Name = "مسجد سلمیان", ShortName = " 257071644")]
    Masjed_e_Soleyman,
    [Display(Name = "مسجد سلیمان خوزستان", ShortName = " 239522675")]
    Masjed_Soleiman_Khuzestan_Iran,
    [Display(Name = "میاندواب", ShortName = " 143735810")]
    Miandoab,
    [Display(Name = "محمدشهر", ShortName = " 234805378")]
    Mohammadshahr,
    [Display(Name = "محمد شهر خراسان جنوبی", ShortName = " 469716753045976")]
    Mohammadshahr_South_Khorasan,
    [Display(Name = "ایستگاه محمد شهر", ShortName = " 1004044438")]
    Mohammad_Shahr_Metro_Station,
    [Display(Name = "نجف اباد", ShortName = " 251135822")]
    Najafabad,
    [Display(Name = "نجف اباد", ShortName = " 249759309")]
    Najafabad_Yazd_Iran,
    [Display(Name = "واژه اباد", ShortName = " 345430843")]
    Vajehabad,
    [Display(Name = "نظراباد", ShortName = " 576767040")]
    Nazarabad,
   
    [Display(Name = "شهرستان نظراباد", ShortName = " 305735749")]
    Nazarabad_County,
    [Display(Name = "نظراباد هرمزگان", ShortName = " 111722515518114")]
    Naz̧Arabad_Hormozgan_Iran,
    [Display(Name = "نظرآباد کرمان", ShortName = " 1014946376")]
    Naz̧Arabad_Kerman_Iran,
    [Display(Name = "نظر آباد کاکاوند", ShortName = " 1006756265")]
    Nazarabad_Kakavand,
    [Display(Name = "نظرآباد چهارمحال بختیاری", ShortName = " 0")]
    Naz̧Arabad_Chahar_Mahall_Va_Bakhtiari_Iran,
    [Display(Name = "هودول گیلان", ShortName = " 826460727")]
    Hudul_Gilan_Iran,
    [Display(Name = "نظرآباد سروستان", ShortName = " 406567830")]
    Nazarabad_Sarvestan,
    [Display(Name = "نظرآباد دلفان", ShortName = " 1032384898")]
    Nazarabad_Delfan,
    [Display(Name = "قزل حصار نظرآباد", ShortName = " 402196038")]
    Qezel_Hesar_Nazarabad,
    [Display(Name = "نظرآباد افتخار آذربایجان غربی ایران", ShortName = " 107316522638714")]
    Naz̧Arabad_E_Eftekhar_Āz̄Ārbāyjān_E_Gharbī_Iran,
    [Display(Name = "نیشابور", ShortName = " 226371163")]
    Neyshabur,
    [Display(Name = "پاکدشت", ShortName = " 273279059")]
    Pakdasht,
    [Display(Name = "شهرستان پاکدشت", ShortName = " 272500615")]
    Pakdasht_County,
   
    [Display(Name = "کریم آباد پاک دشت", ShortName = " 470842317")]
    Karimabad_Pakdasht,
    [Display(Name = "قائم شهر", ShortName = " 235675554")]
    Qa_emshahr,
    [Display(Name = "قرچک", ShortName = " 332480173")]
    Qarchak_Tehran_Iran,
    [Display(Name = "صالح اباد قرچک", ShortName = " 1023811933")]
    Salehabad_Qarchak,
    [Display(Name = "ولی آباد قرچک", ShortName = " 468040099")]
    Valiabad_Qarchak,
    [Display(Name = "امین آباد تهران", ShortName = " 268733340")]
    Aminabad_Tehran_Iran,
    [Display(Name = "قدس", ShortName = " 1020313393")]
    Ghods,
    [Display(Name = "قوچان", ShortName = " 266474369")]
    Quchan,
    [Display(Name = "رفسنجان", ShortName = " 239449507")]
    Rafsanjan,
    [Display(Name = "شهرستان رفسنجان", ShortName = " 249856153")]
    Rafsanjan_County,
    [Display(Name = "رشت", ShortName = " 213115271")]
    Rasht_Iran,
    [Display(Name = "فرودگاه رشت", ShortName = " 213506121")]
    Rasht_Airport,
    [Display(Name = "ساوه شمشک", ShortName = " 1018512572")]
    Rashtriya_Swayamsevak_Sangh,
    [Display(Name = "ربات کریم", ShortName = " 239005835")]
    Robat_Karim,
    [Display(Name = "شهرستان ربات کریم", ShortName = " 251158253")]
    Robat_Karim_County,
    [Display(Name = "سبزوار", ShortName = " 238290646")]
    Sabzevar,
    [Display(Name = "سبزوار کردستان", ShortName = " 627579738")]
    Sabzevar_Kordestan_Iran,
    [Display(Name = "سنندج", ShortName = " 235478642")]
    Sanandaj_Iran,
   
    [Display(Name = "صلوات اباد سنندج", ShortName = " 245177624")]
    Salavatabad_Sanandaj,
    [Display(Name = "سنندج_دو", ShortName = " 1023265577")]
    sanandaj2,

    [Display(Name = "سقز", ShortName = " 239850664")]
    Saqqez_Kordestan_Iran,
    [Display(Name = "ساری", ShortName = " 215412692")]
    Sari_Iran,
    [Display(Name = "ساوه", ShortName = " 236194279")]
    Saveh,

    [Display(Name = "شاهین شهر", ShortName = " 225296803")]
    Shahin_Shahr_Esfahan_Iran,
    [Display(Name = "شهر کرد", ShortName = " 238589355")]
    Shahr_e_Kord,
    [Display(Name = "فرودگاه شهرکرد", ShortName = " 380424385")]
    Shahrekord_Airport,
    [Display(Name = "شهرستان شهرکرد", ShortName = " 235521309")]
    Shahrekord_County,
    [Display(Name = "شهررضا", ShortName = " 251325861")]
    Shahreza,
    [Display(Name = "شهرستان شهررضا", ShortName = " 259255131")]
    Shahreza_County,
    [Display(Name = "اسفراین", ShortName = " 601469602")]
    Esfarjan_Esfahan_Iran,
    [Display(Name = "یحیی اباد شهررضا", ShortName = " 1023927806")]
    Yahyaabad_Shahreza,
    [Display(Name = "منوچهرآباد شهررضا", ShortName = " 864471094")]
    Manuchehrabad_Shahreza,
    [Display(Name = "مهدی آباد شهررضا", ShortName = " 244908973")]
    Mehdiabad_Shahreza,
    [Display(Name = "شهریار ", ShortName = " 234503781")]
    Shahriyar_Tehran_Iran,
    [Display(Name = "شهرستان شهریار", ShortName = " 234880163")]
    Shahriar_County,
    [Display(Name = "شهریار لرستان", ShortName = " 1014835951")]
    Shahriar_Lorestan_Iran,
    [Display(Name = "شهریار چهار محال بختیاری", ShortName = " 1014989754")]
    Shahriar_Chahar_Mahall_Va_Bakhtiari_Iran,
    [Display(Name = "شاهرود هرمزگان", ShortName = " 1015077250")]
    Shahrud_Hormozgan,
    [Display(Name = "شهرستان شاهرود", ShortName = " 285584552")]
    Shahrud_County,
    [Display(Name = "امیریه", ShortName = " 626283300")]
    Amiriyeh_Iran,
    [Display(Name = "شیراز", ShortName = " 216121689")]
    Shiraz_Iran,
    [Display(Name = "انشگاه شیراز", ShortName = " 242957002")]
    Shiraz_University,
    [Display(Name = "فرودگاه شیراز", ShortName = " 235912324")]
    Shiraz_International_Airport,
    [Display(Name = "دوکوهک شیراز", ShortName = " 361703623")]
    Do_Kuhak_Shiraz,
    [Display(Name = "شوشتر", ShortName = " 241818680")]
    Shushtar,
    [Display(Name = "شوشتر اسیاب های آبی تاریخی", ShortName = " 376233222")]
    Shushtar_Historical_Hydraulic_System,
    [Display(Name = "شهرستان شوشتر", ShortName = " 243839286")]
    Shushtar_County,
    [Display(Name = "شوشتری", ShortName = " 570263427")]
    Shushtari_Khuzestan_Iran,
    [Display(Name = "موچریه شوشتر", ShortName = " 1024409654")]
    Mochriyeh_Shushtar,
    [Display(Name = "یشان ساخی خوزستان", ShortName = " 111281692228384")]
    Yeshan_Sakhi_Khuzestan_Iran,
    [Display(Name = "سیرجان", ShortName = " 234483001")]
    Sirjan,
    [Display(Name = "تبریز", ShortName = " 216068756")]
    Tabriz_Iran,
    [Display(Name = "ترب حیدریه", ShortName = " 649887026")]
    Torbat_E_Heydari_Khorasan_Iran,
    [Display(Name = "تربت جام", ShortName = " 243335542")]
    Torbat_E_Jam_Khorasan_Iran,
    [Display(Name = "شهرستان تربت جام", ShortName = " 663486560")]
    Torbat_e_Jam_County,
    [Display(Name = "تربت شیخ جم", ShortName = " 579023768")]
    Torbat_E_Sheykh_Jam_Khorasan_Iran,
   
    [Display(Name = "ارومیه", ShortName = " 214460553")]
    Urmia,
    [Display(Name = "دریاچه ارومیه", ShortName = " 234881281")]
    Lake_Urmia,
    [Display(Name = "ورامین", ShortName = " 239045880")]
    Varamin,
    [Display(Name = "یاسوج", ShortName = " 297648288")]
    Yasuj,
    [Display(Name = "یاسوج شهرستان", ShortName = " 236224717")]
    Yasuj_Fars_Iran,
    [Display(Name = "یزد", ShortName = " 234992356")]
    Yazd_Iran,
    [Display(Name = "استان یزد", ShortName = " 772520741")]
    Yazd_Province,
    [Display(Name = "بافق", ShortName = " 237249026")]
    Bafq_Yazd_Iran,
    [Display(Name = "زابل", ShortName = " 234946709")]
    Zabol,
    [Display(Name = "زابل", ShortName = " 709111146")]
    Zabola,
    [Display(Name = "دانشگاه زابل", ShortName = " 1026178614")]
    Zabol_University,
    [Display(Name = "زاهدان", ShortName = " 240705478")]
    Zahedan,

}
}
