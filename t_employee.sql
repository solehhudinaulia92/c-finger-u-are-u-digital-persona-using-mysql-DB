/*
SQLyog Ultimate v8.63 
MySQL - 5.5.15 : Database - dbfinger
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbfinger` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `dbfinger`;

/*Table structure for table `t_employee` */

DROP TABLE IF EXISTS `t_employee`;

CREATE TABLE `t_employee` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `fingercode` longblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

/*Data for the table `t_employee` */

insert  into `t_employee`(`id`,`name`,`fingercode`) values (16,'SOLEHHUDDIN AULIA','\0øsÈ*ãs\\ÀA7	«qp•Uš ÷s½óœ~“-in¹xµÓªG!hŠ«©^wÙAçæVÀ—ÈÙõ¦‰(Sƒ†k¯ÝŠ@S\né:]‡½ÚM¦Ëªþ¢×%;Ñ¿ª)ª†´‹µ|õEœ¢]Ñ•/Ž!Œ¡—³ìd¹ØûBP?åÂu­`ªj=ž~Ç®»9öAsRlµn$\0uìºG´YõÊè¥…Çµ1ÇvØ…éÊmã#\"òš\Z¤¬è£˜»!»°¼ygŸOgg%cïœ/|ÎF2Ü¸5ÄÔmˆD´À ÜIÌ¢|\\°«E…Ÿü)ˆ$ü¤W(\n˜UC~ç¹üK\r\ZÐþüF*ûŠ´ÝA–ÆUío.¨íz?ô€M;¼OÚd‡–!rç¿ï¤£Ñ¼šüúL¿ÞsÜ®ˆnVK8YúÂT…„Ï‹Ç»‘i­»Ü²Þýf¥mXPåÈƒ0¨ñ‰ðôb¸ðÎÊ¶¨lÛü=o\0øbÈ*ãs\\ÀA7	«qp›UšP;NmP¢]*?E—ÿHádM¦«7YÒë¥‰*ÄNG2ƒ¬O`§îì{úÎg÷\n„¦×BàÑWr¸ ‚1ùIMlb¹cj}”C!‰‹Ï¶–gHr †w8ÊÎùwœŸ,õ´£Î\\¾˜ºæ¢»oBƒ/oqþš.®ÀB#;¾W©¨µÒ\Z™hÿ‡žÎÏ·ôÉýÍF³±˜M2Ï¯ ˜ù=U²dl|óÉö)xr]\0í¶ ÐIùl±)îæs%ÿ«.ò&>èþWÌUHŸLLÜÄÌƒ{ÈŸ–n§BÅëÀ¥Ë¥Q`MœwNï ÷¼ 4A‚£\rX°zØtY×ý…lê`i \nEv¼)ˆÂ«\'Úž»!£ˆ\nñÎãDý(\r©^Âýç‰øLYöÁœ¤°×œúv\\PªÝ<q_P°Có|‰ #WE\Zw,äsÿð<o\0øPÈ*ãs\\ÀA+™Û\r‹7@ÐËR–kï¦ø­aêdÐò$Géñr9ˆ0Î½9A\rU,…øŠT»z]cG”\"K%ˆ	—æÏÆ<ƒ™ÉÞ­¾ZñN/¬À ¢ÿŽ€ƒfXc`[ÚÎm7\0)A\"w¢ËVø“ô%\Zúþr|GÒ»›•çz|»ìýjõ¯éÏ¼!œó˜`èe¶»rÍ³ÀP7àTÃåíæñ÷¡àvmàõ¨Ï\\ìPU•›qžSkª±ÊLŽÚ¨%$ÿ[ÌV”\Z%–²$HÇœ·±ÊÏÈ½»\'˜F	’ê>.ó7à7Ã2Lì}¶OSò7õ°]½g>/oŒ¡+ù.f0QM[›iRÆ‹mË§ƒ>l‹-‹õË\rÕŸ\rð&3Ë¸?‘­YÏ°v„)*Z`÷¯£#’ú×Ã&­‘ÓôîÒ¬žÇÞB;\rQäo\0è\'È*ãs\\ÀA7	«q°ñUš7TØä`¤Ñîˆš	ãM|„Ä*Ýho©uš¦™#²Â	Œ$je‘dW‚ƒ¼×—Vnù>Æ!´©VÍÖD\\ø ô3qæâ{I”‹Êpo·E/ï7BÕU1P¥¥2îOIŽ:€¾ô¹¤Õýç“á •CØ†£]Àò >ã˜„’—FåR4þCÓ~’®±$>µ:o“¢QC¯Ä4³\0%ÓÜ¡ËØûã¨W˜¸vå<®Ÿµ[Ë“Þ~ÿñžš{‰í©ªböËv´tÛ]Çb&N­Äˆ«“\rMé†ò£Ï-9é#¢—ÿ!³EèŸÀ»Æ(d¿@ZsÍÏ«U@VS·°Úñ¥ÁÖ«³ˆ¿&q~V\Z:aþÁmÏo\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0'),(19,'DEDI M','\0ø€È*ãs\\ÀA7	«q°ïUšHÚäñÈ–™•ü\\@Z¶¤QŽù/î	rsGÖˆi/HMA~1ÇÖá‰ñÑíÅ}AÑËm²<…	Ýì›êÞ6ÕÞU|Ö¨ÿõ#IÃûK¬`þ¡À‡(Ó´CføQø[Nÿé¦WSO5O8„tˆV \rØÿ €&_MKü¬õj\'ñ~RCˆÓeâ’”’Á_Ãª1 ø@í”lŽ0µ¡{œã ˆ™ø¬\'€m££«Z\nJi%ëÅ,8o;›CÜC-6ÝÊuYÓÑ\ZÉ™ù­ÛewÔ€\' æQ„È½Â|ý¹ÇpÚ”KFO¸W¯B]/Xúb\'\ZRéØðÒ4¶Šh–>Z	$°(‡¥¦=ªMÆÑï;áq5N¬âã÷n±|æ?2y±°ð´áH—¾Ò5¥p*ªî»@Ôòæ·-Yºl2¤jÊõ	¶êS¢ktÝãfÃŽ)néKÖ{|Ý-êHG îxeëo\0øÈ*ãs\\ÀA7	«q°äUš°;<ßg®æ%¤æ}í³pøù\0í>ÂŒ4ôü\"\'{Ä,©7GÜðVËëIð¢î¬V’å7–AŒàa°è™ç™ß»Þ$BúÄQížwÛZït¢&wk§>ôVâš -ÌâršP…·—ÐæÏÆî¶õuG:œAå-Fqs¢‚N¨‡K\0ªzªóÍ#S+ØÊ·¹\':}dù[­\Z¥õæåGž„ˆËé@ŒVÓæG\\=¿X³æñÈÑç3^±ˆˆîTç÷t×¼Ô£•ëqWGö‚Î“«è­–ìÒëMX+Ÿ ‡ž_.Ö·8ïN7I¥:â\r™fa«øiÍ¾{yÌý1œ+9?<ÅzoÒ–H_ãt6þçUÇú_+i\n¸ÿêé†Ô±ð¾ÃÚ¤¨FEeÊ. ™÷[W u%þHg\0¿bÛ|Šóñ8P‰LÞNŽÌ$Ç}hNÓæýpc¸Š^Ãü;ó\n<ºžŠËÑ-‹o\0øÈ*ãs\\ÀA7	«qðéUšËšŠjU<L°ôTëÄ[êþ``(•aƒœ¦_Ÿ´0 ùð¸ªwÅH95–ÇÕ¢L+’«Ç¶Œ~oôˆG&™¦\"Tî`pªŒ|C´;ŽÊJD¼aå	tíÀå3«°ú–{ƒ¿¤âtb.0ÄëàUzí‡ìEQš°ýº«Z$*ŽópXBµMŸ­hÝ–…KÖ\r\\„6lx#Ãr0ÍS÷Hao·‰Õ\"o^m@îÏzÏ¤;õùž0ð0èÚÝ²3³Œ$A—\nj$S”Ï1þ¤•ä4A‚çÈNÐmì/›Ë‚Ãzl?7#\n9¬1‚-]U¿S¥;M¸ªu Ôs°ys¹\'ž»“Q£‹ýIåq¾›»Œ3NgªVÃu@‹[ª´˜\'b%ƒ­æ´h5ÜÆªž–33·\'(Ø®ºw+×¾ÈÉÃ°ÀK”Ñeóeƒ!60Û¿IbIô&,ÞíåÃbOu\'s6‚Uo\0è€È*ãs\\ÀA7	«q0§Uš½#= d4\n·2$Ìã«€pÎñ‚:îˆu;>löœ×±ï3´^Nb>S\':YùG›¥i•;ònÚ^‚½nzw¬\nJÀë`^¦.¿NSÝ6ÿ\0œ—·úŽ®–Äa‘C‚Ëâ¯ÀC–e¡d^\\¥½ûÀu„\"ßµAUr¢oó+Ï1¦2ä‡68Í³ÑÈÇs†þ-‹jÓ¦èˆ–ÛJûq4‚xg¯´õiMGŠM»@‰îc Š­ºU”>z‘-ƒ/nM¼Øñv6Öµ†RÓ\r]ì/Jfv+˜f~2ÕÅ¡{ÞŒ-ädÔ­Ü±å »óõv\"uÃ!™¦™’ü1 žFvHuV§ÈçàýTn*q’Cº¬c‘‘&ue89ùWSjrXùF§f\r…É¶#FFU¼ÿ×ãƒçù_a«ç¨yÙ…˜å6\nRWrö¾yàºE}úðÒ0=l¥!¹ãºê? Œüø\\Ožo\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0'),(20,'DEDI M','\0øÈ*ãs\\ÀA7	«qðèUše*˜D™ì„àÓˆr(ª?`ÊÅ†çü\Z2š•*™;$Æÿµ¤l¦þ®2h‘_ï,!!Ø¯J`Wm!«Î£>&ç’^¦cxŸy<Ú´E|›#s!a]oªU×þ7v…û×ÍN˜SÝ_\rÊ\'b„ºoô\r&X®Ž²ÓzOºvÚ=zM‡Mé¸|faEž}!Ï\'n¹:	~S´gúÐ2ÄT	ìÅ€8ÔcFýäß+@C¢…èKo\\Ý4Uq­ÂÓèÊ\nµF«Ž(^Òž\r5(\nlq^·Zwÿ³ÿy…››30ögçF’.¯ÆØQeáÅE–˜‹=÷MªS£ú¥BæàÔ.&^¦¼Nì8ƒœc\0ä_õJ~¶È‰?„éðŽë#JñE­H}*ß·-é¯ƒ\n¤üŠŸ¨.Œ®gªÿ=½è¥z|;òùz|XÐlÎÊ†ì&³@g¶$Ç>ÝD-üÑA”|Ã=Xˆ±òÈÁáv–o\0øÈ*ãs\\ÀA7	«q0ÃUšŒ‡­àT7ô½3}2\0#fYŠŠ¯§6rÉ%¶X€«Ç.Jò“ã„Ìw÷FÂÞDª&yÕl°›ã¿“7¿÷X|„µ®nÅÙÇ\ZbÀÈIåÓyõe–<¹¢A¾(E®¿À!ð\ZåÔ<\\¯é5¿—õt‡\ršÝz ½ý÷SÃøM#UJ9£]f#‘z$66ñ«:Ž*í`àÆd–¼Â%ÊDÄç\"–w2±\r>SÌ®°)T¿ÝˆÏüÆ£³(ŸÿâzwÐvï5¢Tg´¨ªýÀ‰1ÈÍ@ô´©a?k”á£»û{Æ¼r\"T,ñÏÜ³Ô%x„VQ¢¾¾jåt[zE %ßµ\"éæ¼0ó%1î—z\Z%•=ÓIÐ%;HWþÛÚ²5é=2±¬ÓdÔÊrÑÿ¢	¯!‡ØÂvtŸ`QbýÛÀ·öA äà^ºŽóümèFFÛô>Àï\r\0’Õ>ŠÑx9µ×ÈÏñ@‘Õìý2ªo\0ø€È*ãs\\ÀA7	«q°ÒUš²LÚezžèht8¿þX®<íb–˜\0ü™—å7²\n*GŸñRœr%šUg\Z[\np´ëPµŽŸ;~pžo£ð§ÀúFÎ,´Æõœ^^üTn‹èþ\'Õ4²uóP*w;„~D”‚Œ‚ýS/tÍ\nÒÿ…­úíUJÖ9Ñüž‡Åº8»ä€5.\nð*Nl5(˜Ü”¶sƒ×mï^yK÷E<\nA%‰%Ü1+)%qÝy¸ý€¼GF7H mª@7½l62…ûka•!ïÈ‘(ÍÊc¢Í8\"Œã€á\n´kå¡çÝØ^ŸËðg?.–\0“4.ø¡)bÛc]SÄc1¦;Ì?–ò­C>¿5\'9TÃZùÞ¢dÇnL‘Ð Ì°?,¼ªCX±X)b¨*ã 8X(À‰/#¶®á¤šç¾•ºOŽë&£s¸\0\Z0ñ±%äÔª¦C@Öx„Î@Ö·é%hd7ìÈ]U>/ÝŠ†£o\0è~È*ãs\\ÀA7	«qð4Uš‡\\ëj_lèk¹oÍA5ÐèG±P½F_¦\\®iü*uBÄZ•ìšz§ÂË¤õzÈœ7Þ(PEðÈ…&IRFwÙÙº>~ëfõZþêbcã_5’êšÓeË²Þ§-ÌnïD!œÚN~¢?HF]vjG¹§éä©QŒm™¥²ô=+«ŸÆéÔ]¤dAM4ðÐr®z·ÜžI2×2ƒ†>£µJé±§#Í¶ªÚÔ_9æïù¦ÍºÆ?å%x1|Ò¯nƒ\0wºdQ\'¬zAhmöåmâ\'‡OÏ¼òÐ?­òkKãñ¹Û¦õ½Àý‚\'#²-ÿ-x6ÿŽæ!”qÌ•ê\n†WÀd*Ž;Rñ?Ã&ä§òß.aCô)X²Û„htXË½] FxÔ¤§eß{Öÿ“½™È!/)±ü6úÖ®Ù¹=_¶ž­ä±=dV;A°û¼*ú‚³\0gßUÞé.Ìâÿ)˜Õ £&\\j…ì1ÔÒÂ™.o\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0'),(21,'ABDUL IMRON','\0øÈ*ãs\\ÀA7	«qð»Uš£bÄªMÇÍ·Ä¤‡,¨àÑê~å\\ìÖdxnÞþ‰Fúl×“´&#¸÷I2_ãq|%BižŸŽô ±óW3£óôb¢Ë™ùÿ!Îð¼9(…or®à¸šì¥S‡ÝeQÐofŸuñ”[ÃÊ	+¸ÒS²<u8dÊ{Ù±ŒÕõÎ©7@à9ˆî)«SBb8RW.h×lzÄ\nÅ³5Šðá$]€ä£vÆ×T!Œ+‹Yçÿ*-Žô’]fŽ˜3BÍ©\"2¦õ˜”N%B3Þ¬«Ã—îBƒ+ú6î}’.îpòG[U|ågÎ-LzæD›xÖz³ƒº‡µÙÅiˆÖt‡YS2Ô™áläBæñ²FãÅ0`v[ÁÕïeXTBÝõoõ‡çU7>°9àÇóò¤gËçºYØ÷e3Àú)Ç7GË“ºL»³&èsAÆj“mÆÎ¸ÄtÑŸæ„÷4¤¯ý hGŠ¬Žo\0øÈ*ãs\\ÀA7	«qð»Uš£|°s\0Ïó¨9ô?Óq”Õ%†›H5,ìN}IjŸ|†ì)V\nøü$Ûc2jÔV¥Þeù&æ–4œeØó¹0‡ÄÔÆX¬ÅHÚÆˆôÝËh¬+ÖïÔ$B›­…ÄÛþD¦(ÐG@u Bgpxaþµˆ-á†¡aÐ`Šõ®\'‘áôÓw-6Æ¡Îô%Z§*Â)ËVB%ÿ‡³¨%È£\rª£ª €ì¬wÃ³7iKå\r{ž,ih—¹ÃœÕ¾gì\0Z(nŸôh”ì\\¸ÂXøQ‡Îó£5šIÓIÍßdýîuÿöA¦Ñ^Åæá¼ë’(@‹LfR¿ÆíàÂîvfŠVì­-iÀB‚ÍHÄã´ýÑÔ¨ÝŸ(#rz_XÈŽ½òö	&ÙØ\Zj®›èk3J¶Ú´fÙî\"Ÿ‚ËÓŒYôzÆæV	¹n°}Š2HvÃÆwŸkçûÑí]‰Ü„]	˜F:Î¿Ã¤eø?Î¸2Ço\0ø~È*ãs\\ÀA7	«q°LUšÿ·\0,Q®xç9œT•\0ëÍj\0J‰¨6ñº\"’)bóÞiî¾OF\\•\"È\'Ú\r5võê6ëPæöôõS×Á6Ê!¼æÏ«Ù£ù˜Kr%M«jç`:”Ôeá P¡Þ\\ ëO¥#]žãèÈG6ó8¾R¿ø¬ðj–’ DÆ7…N¶ÅÍÃq?B´¹Bé”MÚ_®<kG|ë«¼ >æ·çrÍÁR¥%¢Üˆs²18Kîå@ëçí´!(\ZeaE†ì›Úù†{Ëˆév†y80¬Ùë!=‡Duµõ)0H_%LKã}ï¸BÒ,zÃSS<–1£ìlûWLõ%Ò„¶öê;ì§[{C	Ÿ&×t‡>Ja]#§TN.¶\Z@]j[±$›ú-8ùs¹ßtµœÏÖf}¦{oÂâž*ß!˜Î…ÞÖD¹Î˜€+2õ*>,ìŒàÄHÖ‹<ü©x?ºe#5d»4ñ®21T!ãqh£ŒÌOÏ†o\0è~È*ãs\\ÀA7	«qð³UšF«_#ÑE×gkö·”vD!à¿y’^¬PãÑýÙf[³ŽÞ±7ÞxÝÓåw§nŒÊªÂ	d5Ç„¡àGÒIAÂs˜š6E¿J ?Ü	}j—˜’t¬ÕÕ¯Õå]ï³có™5#ÍH¼/U=Î©7âÚ¿¿RN€Ëƒ\0•Ú	„Ì¤ê4Ã~+*§ÞÀµÅ<Éª¡þl«›³êxqmÖþV>Æ\'ÈzÛÒëý£.ì\\BáÊêÜžEaÑuL!8KÞ­XÆyvM@à-³¨ÐéB\r>á*Q‘;«”‹OkWòöà¬#ŽýÊ`²lÅ“)È©Y®‡‹>OÔÅ™n0q‘Ú÷ÊE-¥©ÆŠ~TÑÎÈù*Ð5ž¿¯tÈCe×V™PÛ’Å­c;õz1°Æ5‰íþ ç‘Þ0f«úYÑ”©&xž¦ÂOI\0qcEsU¡†fö–‡IkÎÞKá¦é¼ÕcA™µ\'oU\0V\0W\0X\0Y\0Z\0[\0\\\0]\0^\0_\0`\0a\0b\0c\0d\0e\0f\0g\0h\0i\0j\0k\0l\0m\0n\0o\0p\0q\0r\0s\0t\0u\0v\0w\0x\0y\0z\0{\0');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
