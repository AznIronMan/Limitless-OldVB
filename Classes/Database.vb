Public Class Database

    Shared ReadOnly SavePath As String = MemoryBank.DataDir & "\"
    Shared DefaultSave As String = Settings.SettingsDB
    Shared ReadOnly SaveExt As String = MemoryBank.SavesExtL
    Public Shared Sub CheckForDB(savename As String)
        DefaultSave = Settings.SettingsDB
        Dim DBExists As Boolean = System.IO.File.Exists(SavePath & savename & SaveExt),
            DefaultExists As Boolean = System.IO.File.Exists(SavePath & DefaultSave & SaveExt)
        If DBExists Then
            'MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(savename)
            'MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(savename)
        Else
            If DefaultExists Then
                MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(savename) & " not available.  Switching to " &
                   ClarkTribeGames.Converters.UppercaseEachFirstLetter(DefaultSave) & ".")
                ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                    "lastdb", {"settingConfig"}, {DefaultSave})
                Settings.SettingsDB = LCase(DefaultSave)
                'MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
                'MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
            Else
                If savename = DefaultSave Then
                    MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(savename) & " not available.  Generating a new " &
                    ClarkTribeGames.Converters.UppercaseEachFirstLetter(DefaultSave) & " Database.")
                Else
                    MsgBox(ClarkTribeGames.Converters.UppercaseEachFirstLetter(savename) & " and " &
                    ClarkTribeGames.Converters.UppercaseEachFirstLetter(DefaultSave) & " not available.  Generating a new " &
                    ClarkTribeGames.Converters.UppercaseEachFirstLetter(DefaultSave) & " Database.")
                End If
                CreateEmptyDB(ClarkTribeGames.Converters.UppercaseEachFirstLetter(DefaultSave))
                ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                    "database", {"settingConfig"}, {DefaultSave})
                'ClarkTribeGames.SQLite.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                '    "lastdb", {"settingConfig"}, {DefaultSave})
                'Settings.SettingsLastDB = LCase(DefaultSave)
                Settings.SettingsDB = LCase(DefaultSave)
                'MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
                'MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
            End If
        End If
    End Sub

    Public Shared Function DBFolderQuery() As List(Of String)
        Dim list As New List(Of String)
        For Each Item In ClarkTribeGames.FilesFolders.GetFilesInFolder(MemoryBank.DataDir)
            If Item.Contains(MemoryBank.SavesExtL) Then
                list.Add(Item.Replace(MemoryBank.DataDir & "\", ""))
            End If
        Next
        Return list
    End Function


    Public Shared Sub VersionChecker()
        If ClarkTribeGames.Web.CheckWeb() Then
            Dim DBOnline As String = ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName & "db"), "v")
            Dim DBLocal As String = ClarkTribeGames.SQLite.GetCol(MemoryBank.DataDir, Settings.SettingsDB &
            MemoryBank.SavesExtL, "dbInfo", "dbVersion").Split(",")(0)
            If (CInt(DBOnline.Replace(".", "")) > CInt(DBLocal.Replace(".", ""))) Then
                Dim answer As Integer = MsgBox("Newer version " & DBOnline & " of Default Database available!" &
                    vbCrLf & vbCrLf & "Do you want to replace your existing " & DBLocal & " with the newer version?",
                    vbYesNo)
                If answer = vbYes Then
                    Using client = New System.Net.WebClient()
                        client.DownloadFile(ClarkTribeGames.MySQLReader.Query(LCase(Application.ProductName & "db"), "u"),
                            MemoryBank.DataDir & "/Default" & MemoryBank.SavesExtL)
                    End Using
                Else
                    MsgBox("Please consider an upgrade to the default database as the existing version may not work with " &
                        "this version of the game.")
                End If
            End If
        End If
    End Sub

    Public Shared Function GetDBName(savename As String) As String
        Return ClarkTribeGames.SQLite.GetCol(MemoryBank.DataDir, savename, "dbInfo", "dbName").Split(",")(0)
    End Function
    Public Shared Sub CreateEmptyDB(savename As String)
        ClarkTribeGames.SQLite.CreateDB(SavePath, savename & SaveExt, "
            CREATE TABLE 'all_Index' ('idxID' TEXT NOT NULL UNIQUE,'idxName' TEXT NOT NULL, 'idxDesc' TEXT, 
            'idxHidden' TEXT NOT NULL, 'idxActive' TEXT NOT NULL DEFAULT 1, PRIMARY KEY('idxID'));
            CREATE TABLE 'dbInfo' ('dbName' TEXT NOT NULL, 'dbVersion' TEXT NOT NULL);
            CREATE TABLE 'dbToons' ('toonID' TEXT NOT NULL, 'toonName' TEXT NOT NULL, 'toonUID' TEXT NOT NULL,
            'toonRace' TEXT NOT NULL, 'toonClass' TEXT NOT NULL, 'toonAlign' TEXT NOT NULL, 'toonGender' TEXT NOT NULL, 
            'toonAge' TEXT NOT NULL, 'toonStartLv' TEXT NOT NULL, 'toonBio' TEXT, 'toonImage' TEXT, 'toonProf' TEXT, 'toonAbl' TEXT, 
            'toonEff' TEXT, 'toonHeld' TEXT, 'toonWear' TEXT, 'toonCharms' TEXT, 'toonInv' TEXT, 'toonForce' TEXT NOT NULL, 
            'toonAlias'  TEXT, 'toonDestiny' TEXT NOT NULL, 'toonTheme' TEXT, 'toonVerse' TEXT NOT NULL, 'toonLang' TEXT, 
            'toonCode' TEXT);
            CREATE TABLE 'dbRace' ('raceID' TEXT NOT NULL, 'raceName' TEXT NOT NULL, 'raceDesc' TEXT, 
            'raceSize' TEXT NOT NULL, 'raceGender' TEXT NOT NULL, 'raceAge' TEXT NOT NULL, 'raceStats' TEXT NOT NULL, 
            'raceBio' TEXT NOT NULL, 'raceProf' TEXT, 'raceAbl' TEXT, 'raceEff' TEXT, 'raceForce' TEXT,
            'raceCode' TEXT);
            CREATE TABLE 'dbClass' ('classID' TEXT NOT NULL, 'className' TEXT NOT NULL, 'classDesc' TEXT, 
            'classStats' TEXT NOT NULL, 'classBio' TEXT NOT NULL, 'classProf' TEXT, 'classAbl' TEXT, 'classEff' TEXT,
            'classCode' TEXT);
            CREATE TABLE 'dbSize' ('sizeID' TEXT NOT NULL, 'sizeName' TEXT NOT NULL, 'sizeDesc' TEXT, 
            'sizeStats' TEXT, 'sizeBio' TEXT NOT NULL, 'sizeProf' TEXT, 'sizeAbl' TEXT, 'sizeEff' TEXT, 'sizeCode' TEXT);
            CREATE TABLE 'dbAlign' ('alignID' TEXT NOT NULL, 'alignName' TEXT NOT NULL, 'alignDesc' TEXT, 
            'alignRank' TEXT NOT NULL, 'alignStats' TEXT, 'alignRep' TEXT NOT NULL, 'alignBio' TEXT NOT NULL, 
            'alignProf' TEXT, 'alignAbl' TEXT, 'alignEff' TEXT, 'alignCode' TEXT);
            CREATE TABLE 'dbGender' ('genderID' TEXT NOT NULL, 'genderName' TEXT NOT NULL, 'genderDesc' TEXT, 
            'genderStats' TEXT, 'genderBio' TEXT NOT NULL, 'genderPro' TEXT NOT NULL, 'genderProf' TEXT, 'genderAbl' TEXT, 
            'genderEff' TEXT,'genderCode' TEXT);
            CREATE TABLE 'dbAge' ('ageID' TEXT NOT NULL, 'ageName' TEXT NOT NULL, 'ageCriteria' TEXT NOT NULL, 
            'ageDesc' TEXT NOT NULL, 'ageCode' TEXT);
            CREATE TABLE 'dbAbl' ('ablID' TEXT NOT NULL, 'ablName' TEXT NOT NULL, 'ablDesc' TEXT, 'ablType' TEXT NOT NULL, 
            'ablCost' TEXT NOT NULL, 'ablTarget' TEXT NOT NULL, 'ablImpact' TEXT NOT NULL, 'ablBase' TEXT NOT NULL, 
            'ablElem' TEXT, 'ablEff' TEXT, 'ablRequire' TEXT, 'ablCode' TEXT);
            CREATE TABLE 'dbAblType' ('abltypeID' TEXT NOT NULL, 'abltypeName' TEXT NOT NULL, 'abltypeCode' TEXT);
            CREATE TABLE 'dbEff' ('effID' TEXT NOT NULL, 'effName' TEXT NOT NULL, 'effDesc' TEXT, 'effType' TEXT NOT NULL, 
            'effCriteria' TEXT, 'effImpact' TEXT, 'effIncRate' TEXT, 'effElemAbs' TEXT, 'effElemPos' TEXT, 
            'effElemNeg' TEXT, 'effReflect' TEXT, 'effTeamMod' TEXT, 'effAlignMod' TEXT, 'effGenderMod' TEXT, 
            'effRaceMod' TEXT, 'effSizeMod' TEXT, 'effBio' TEXT, 'effCode' TEXT);
            CREATE TABLE 'dbEffType' ('efftypeID' TEXT NOT NULL, 'efftypeName' TEXT NOT NULL, 'efftypeDesc' TEXT,
            'efftypeCode' TEXT);
            CREATE TABLE 'dbItems' ('itemID' TEXT NOT NULL, 'itemName' TEXT NOT NULL, 'itemDesc' TEXT, 
            'itemClass' TEXT NOT NULL,'itemType' TEXT NOT NULL, 'itemSizeR' TEXT, 'itemRaceR' TEXT, 'itemClassR' TEXT, 
            'itemEffR' TEXT, 'itemAlignR' TEXT, 'itemProfR' TEXT, 'itemStats' TEXT, 'itemBio' TEXT, 'itemProf' TEXT, 
            'itemAbl' TEXT, 'itemEff' TEXT, 'itemElement' TEXT, 'itemMax' TEXT NOT NULL, 'itemCode' TEXT);
            CREATE TABLE 'dbItemType' ('itemtypeID' TEXT NOT NULL, 'itemtypeName' TEXT NOT NULL, 'itemtypeClass' TEXT NOT NULL,
            'itemtypeCode' TEXT NOT NULL);
            CREATE TABLE 'dbItemClass' ('itemclassID' TEXT NOT NULL, 'itemclassName' TEXT NOT NULL, 
            'itemclassCode' TEXT);
            CREATE TABLE 'dbForce' ('forceID' TEXT NOT NULL, 'forceName' TEXT NOT NULL, 'forceText' TEXT NOT NULL, 
            'forceObtain' TEXT NOT NULL, 'forceOwner' TEXT NOT NULL, 'forceDesc' TEXT, 'forceCode' TEXT);
            CREATE TABLE 'dbForceObtain' ('forceOID' TEXT NOT NULL, 'forceOName' TEXT NOT NULL, 'forceOText' TEXT NOT NULL,
            'forceOCode' TEXT);
            CREATE TABLE 'dbAlias' ('aliasID' TEXT NOT NULL, 'aliasName' TEXT NOT NULL, 'aliasType' TEXT NOT NULL, 
            'aliasRace' TEXT NOT NULL,'aliasAlign' TEXT NOT NULL, 'aliasGender' TEXT NOT NULL, 'aliasJob' TEXT, 
            'aliasBio' TEXT, 'aliasImage' TEXT, 'aliasKnown' TEXT, 'aliasCode' TEXT);
            CREATE TABLE 'dbDestiny' ('destinyID' TEXT NOT NULL, 'destinyName' TEXT NOT NULL, 'destinyDesc' TEXT, 
            'destinyCode' TEXT);
            CREATE TABLE 'dbEnviro' ('enviroID' TEXT NOT NULL, 'enviroName' TEXT NOT NULL, 'enviroEff' TEXT, 'enviroDesc' TEXT, 
            'enviroCode' TEXT);
            CREATE TABLE 'dbGeneric' ('genericID' TEXT NOT NULL, 'genericName' TEXT NOT NULL, 'genericRace' TEXT NOT NULL, 
            'genericClass' TEXT NOT NULL, 'genericAlignMin' TEXT NOT NULL, 'genericAlignMax' TEXT NOT NULL, 
            'genericGender' TEXT NOT NULL, 'genericMinLv' TEXT NOT NULL, 'genericMaxLv' TEXT NOT NULL, 
            'genericBio' TEXT, 'genericImage' TEXT, 'genericProf' TEXT, 'genericAbl' TEXT, 'genericEff' TEXT, 
            'genericHeld' TEXT, 'genericWear' TEXT, 'genericCharms' TEXT, 'genericInv' TEXT, 'genericMax' TEXT, 'genericCode' TEXT);
            CREATE TABLE 'dbJobs' ('jobID' TEXT NOT NULL, 'jobName' TEXT NOT NULL, 'jobRace' TEXT, 'jobClass' TEXT, 
            'jobBio' TEXT NOT NULL, 'jobProf' TEXT, 'jobHeld' TEXT, 'jobWear' TEXT, 'jobCharms' TEXT, 'jobInv' TEXT, 'jobCode' TEXT);
            CREATE TABLE 'dbStatus' ('statusID' TEXT NOT NULL, 'statusName' TEXT NOT NULL, 'statusColor' TEXT NOT NULL, 
            'statusDesc' TEXT NOT NULL, 'statusBio' TEXT NOT NULL, 'statusEffRank' TEXT NOT NULL, 'statusEff' TEXT NOT NULL,
            'statusCode' TEXT);
            CREATE TABLE 'dbArenas' ('arenaID' TEXT NOT NULL, 'arenaName' TEXT NOT NULL, 'arenaVerse' TEXT NOT NULL, 
            'arenaDesc' TEXT,'arenaX' TEXT NOT NULL, 'arenaY' TEXT NOT NULL, 'arenaZ' TEXT NOT NULL, 'arenaActive' TEXT NOT NULL, 
            'arenaSpace' TEXT NOT NULL,'arenaHell' TEXT NOT NULL, 'arenaUnder' TEXT NOT NULL, 'areanCeiling' TEXT NOT NULL,
            'arenaCode' TEXT);
            CREATE TABLE 'dbSections' ('sectionID' TEXT NOT NULL, 'sectionArena' TEXT NOT NULL, 'sectionName' TEXT NOT NULL, 
            'sectionStart' TEXT NOT NULL, 'sectionEnd' TEXT NOT NULL, 'sectionEnv' TEXT, 'sectionColor' TEXT,
            'sectionDesc' TEXT NOT NULL, 'sectionSpawn' TEXT NOT NULL, 'sectionCode' TEXT);
            CREATE TABLE 'dbElements' ('elementID' TEXT NOT NULL, 'elementName' TEXT NOT NULL, 'elementDesc' TEXT, 
            'elementCode' TEXT);
            CREATE TABLE 'dbVerse' ('verseID' TEXT NOT NULL, 'verseName' TEXT NOT NULL, 'verseDesc' TEXT, 'verseBio' TEXT, 
            'verseActive' TEXT NOT NULL, 'verseTheme' TEXT, 'verseCode' TEXT);
            CREATE TABLE 'dbTeam' ('teamID' TEXT NOT NULL, 'teamName' TEXT NOT NULL, 'teamMembers' TEXT NOT NULL,
            'teamBio' TEXT, 'teamTheme' TEXT, 'teamType' TEXT NOT NULL, 'teamCode' TEXT);
            CREATE TABLE 'dbRelation' ('relationID' TEXT NOT NULL, 'relationName' TEXT NOT NULL, 'relation1' TEXT NOT NULL,
            'relation2' TEXT NOT NULL, 'relationType' TEXT NOT NULL, 'relationDate' TEXT NOT NULL, 
            'relationActive' TEXT NOT NULL, 'relationCode' TEXT);
            CREATE TABLE 'dbLang' ('langID' TEXT NOT NULL, 'langName' TEXT NOT NULL, 'langRace' TEXT NOT NULL, 'langBio' TEXT,
            'langDesc' TEXT, 'langLearn' TEXT NOT NULL, 'langEncrypt' TEXT, 'langCode' TEXT);
            CREATE TABLE 'dbExistence' ('existID' TEXT NOT NULL, 'existName' TEXT NOT NULL, 'existDesc' TEXT, 'existBio' TEXT NOT NULL,
            'existUID' TEXT NOT NULL, 'existCode' TEXT);
            CREATE TABLE 'dbProf' ('profID' TEXT NOT NULL, 'profName' TEXT NOT NULL, 'profType' TEXT NOT NULL, 'profDesc' TEXT, 'profCode' TEXT,
            PRIMARY KEY('profID'));
            CREATE TABLE 'dbModi' ('modiID' TEXT NOT NULL, 'modiName' TEXT NOT NULL, 'modiShort' TEXT NOT NULL, 'modiDesc' TEXT, PRIMARY KEY('modiID'));
            CREATE TABLE 'dbAblModi' ('ablmID' TEXT NOT NULL, 'ablmMin' TEXT NOT NULL, 'ablmMax' TEXT NOT NULL, 'ablmMod' TEXT NOT NULL,
            PRIMARY KEY('ablmID'));
            CREATE TABLE 'dbStats' ('statID' TEXT NOT NULL, 'statName' TEXT NOT NULL, 'statDesc' TEXT NOT NULL, 'statMods' TEXT NOT NULL, 
            'statCode' TEXT, PRIMARY KEY('statID'));
            ")

        'Toon:      UID 0:Prime,1:Generic,2:Split,3:Clone,4:Variant,5:Twin,6:Shapeshifter,7:Alternative
        'Effects:   Type 0:Perm,1:Temp,2:PermInc,3:TempInc,4:Attr // Rate T:Turn,M:Minute,H:Hour,D:Day,Y:Year // Reflect 0:Off,1:On //
        '           Team 1:ChangeTeam,N:NoTeam // Align: +1:IncreaseRank,-1:DecreaseRank,N:for50(Neutral)
        'Force:     Text 0:none,1:toonname's item, 2:item of toonname // obtain 0:physical,1:magical,2:specialitem(xItem),3:enchanted(xItem) //
        '           Owner 0:instantdeath (destroy),1:control
        'Alias:     Type 0:NameOnlyNoSecret,1:TransformationNoSecret,2:SecretwithFake,3:SecretwithTrans // Race #:RaceID,=:whatevertoonis
        '           Align Cosmetic #:= // Gender #:= // Known: IfType2Or3:toonID
        'Job:       Class #:SimliarTo
        'Arena:     X: West2East(Long)Odd# // Y: North2South(Lat)Odd# // Z:Up2Down(Height)Odd# // Active/Space/Hell/Ceiling 0:No,1:Yes //
        '           Under: 0:No,#:NumOfLayers
        'Section    Start/End: x.y.z,scaledTo0.1.2=x.y,scaledTo0.1.2.3.4=z // Env 0:Normal,#:Environment // Spawn 0:no,1:yes
        'Team       Type: 0:Standard,1:Alliance,2:Partners,3:Family,4:Unstable,5:Mercenary

        'all_Index
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'all_Index' VALUES ('0','Abilities',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('1','Abilities Modifiers',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('2','Abilities Types',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('3','Ages',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('4','Aliases',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('5','Arenas',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('6','Characters',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('7','Classes',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('8','Destinies',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('9','Editor Categories',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('10','Effects',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('11','Effect Types',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('12','Elements',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('13','Environments',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('14','Existences',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('15','Genders',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('16','Items',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('17','Item Classes',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('18','Item Types',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('19','Jobs',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('20','Languages',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('21','Life Forces',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('22','Life Force Obtains',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('23','Modifiers',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('24','Multiverse',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('25','Proficiencies',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('26','Races',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('27','Relationships',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('28','Sections',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('29','Sizes',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('30','Stats',NULL,'1','1');
            INSERT INTO 'all_Index' VALUES ('31','Statuses',NULL,'0','1');
            INSERT INTO 'all_Index' VALUES ('32','Teams',NULL,'0','1');
            ")

        'dbAbl
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAbl' VALUES ('0','Punch',NULL,'0','Z','AT','Z','Z',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAbl' VALUES ('1','Kick',NULL,'0','Z','AT','Z','Z',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAbl' VALUES ('2','Defend',NULL,'1','Z','SA','Z','Z',NULL,NULL,NULL,NULL);
            ")

        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAblModi' VALUES ('0','0','9','S4');
            INSERT INTO 'dbAblModi' VALUES ('1','10','19','S3');
            INSERT INTO 'dbAblModi' VALUES ('2','20','29','S2');
            INSERT INTO 'dbAblModi' VALUES ('3','30','39','S1');
            INSERT INTO 'dbAblModi' VALUES ('4','40','49','A0');
            INSERT INTO 'dbAblModi' VALUES ('5','50','59','A1');
            INSERT INTO 'dbAblModi' VALUES ('6','60','69','A2');
            INSERT INTO 'dbAblModi' VALUES ('7','70','79','A3');
            INSERT INTO 'dbAblModi' VALUES ('8','80','89','A4');
            INSERT INTO 'dbAblModi' VALUES ('9','90','99','A5');
            INSERT INTO 'dbAblModi' VALUES ('10','100','99999','D10S4');
            ")

        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAblType' VALUES ('0','Attack',NULL);
            INSERT INTO 'dbAblType' VALUES ('1','Defense',NULL);
            INSERT INTO 'dbAblType' VALUES ('2','Passive',NULL);
            INSERT INTO 'dbAblType' VALUES ('3','Holy',NULL);
            INSERT INTO 'dbAblType' VALUES ('4','Dark',NULL);
            INSERT INTO 'dbAblType' VALUES ('5','Effect',NULL);
            INSERT INTO 'dbAblType' VALUES ('6','Ninja',NULL);
            ")

        'dbAge
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAge' VALUES ('0','Baby','<1 or 2%','Newborn to very young',NULL);
            INSERT INTO 'dbAge' VALUES ('1','Adolescent','>=1 and <12%','Child age to teenager',NULL);
            INSERT INTO 'dbAge' VALUES ('2','Youthful','>=12% and <20%','Early Adult Life',NULL);
            INSERT INTO 'dbAge' VALUES ('3','Young','>=20% and <30%','Young Adult, Starting to Mature',NULL);
            INSERT INTO 'dbAge' VALUES ('4','Mid-Aged','>=30% and <50%','Middle of Life',NULL);
            INSERT INTO 'dbAge' VALUES ('5','Old','>=50% and <80%','Past Prime, Starting to Show Age',NULL);
            INSERT INTO 'dbAge' VALUES ('6','Elder','>=80% and <200','Late Stage of Life, Very Aged',NULL);
            INSERT INTO 'dbAge' VALUES ('7','Ancient','>=85% and >200','Centuries Old',NULL);
            ")

        'dbAlign
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAlign' VALUES ('0','Lawful Good','Always does the right thing no matter what','100',NULL,'4','a Lawful Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('1','Neutral Good','Does right but never takes a side','87',NULL,'3','a Neutral Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('2','Chaotic Good','Does the right thing but at any means necessary','75',NULL,'2','a Chaotic Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('3','Lawful Neutral','Good with a dash of grey','63',NULL,'1','a Lawful Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('4','True Neutral','In the middle','50',NULL,'0','a True Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('5','Chaotic Neutral','Chooses the dark path but does not take sides','37',NULL,1,'a Chaotic Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('6','Lawful Evil','The law but does things dark','25',NULL,'2','a Lawful Evil',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('7','Neutral Evil','Bad in a sense but not all the way dark','13',NULL,'3','a Neutral Evil',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('8','Chaotic Evil','Chaos makes this one happy','0',NULL,'4','a Chaotic Evil',NULL,NULL,NULL,NULL);
            ")

        'dbArenas
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbArenas' VALUES ('0','The Arena','0',
            'This is the default arena.','3','3','3','1','1','1','5','0',NULL);")

        'dbExistence
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbExistence' VALUES ('0', 'Prime', 'Original form of this character.','is the Prime version of','O',NULL);
            INSERT INTO 'dbExistence' VALUES ('1', 'Generic', 'Designed to be a non-named character in mass volume.','is the Generic version of','G',NULL);
            INSERT INTO 'dbExistence' VALUES ('2', 'Split', 'Created from Prime with a Split ability.  Usually half the status as Prime.','is the Split version of','S',NULL);
            INSERT INTO 'dbExistence' VALUES ('3', 'Clone', 'Duplicate created from a Prime.  Identical but not the original.','is the Clone version of','C',NULL);
            INSERT INTO 'dbExistence' VALUES ('4', 'Variant', 'An alternate version of the Prime from a different timeline.','is the Variant version of','V',NULL);
            INSERT INTO 'dbExistence' VALUES ('5', 'Twin', 'Considered Prime but born with an exact twin at birth.','is the Twin version of','T',NULL);
            INSERT INTO 'dbExistence' VALUES ('6', 'Shapeshifter', 'Hidden stat (except if player is shifting).  Hides as Prime of a character but is actually a clone.','is the Prime version of','F',NULL);
            ")

        'dbDestiny
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbDestiny' VALUES ('0','Competitive','Competes in Arenas (Default).',NULL);
            INSERT INTO 'dbDestiny' VALUES ('1','Passive','Non-competitive.',NULL);
            INSERT INTO 'dbDestiny' VALUES ('2','Justice','Focuses on making injustices right.',NULL);
            INSERT INTO 'dbDestiny' VALUES ('3','Chaos','Focuses on causing as much chaos as possible.',NULL);
            INSERT INTO 'dbDestiny' VALUES ('4','Universe Balance','Focuses on gathering Relics to bring balance to the Universe by halving the population of all living beings.',NULL);
            INSERT INTO 'dbDestiny' VALUES ('5','Death','Focuses on no mercy and death to all without basis.',NULL);
            ")

        'dbElements
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbElements' VALUES ('0','Fire',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('1','Ice',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('2','Wind',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('3','Water',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('4','Earth',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('5','Thunder',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('6','Sun',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('7','Holy',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('8','Dark',NULL,NULL);
            INSERT INTO 'dbElements' VALUES ('9','Venom',NULL,NULL);
            ")

        'dbEnviro
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbEnviro' VALUES ('0','Normal',NULL,'Everything is Normal.',NULL);")

        'dbForce
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbForce' VALUES ('0','Heart','the Heart of','1','1',NULL,NULL);")

        'dbForceObtain
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbForce' VALUES ('1','Soul','the Soul of','1','1',NULL,NULL);")

        'dbGender
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbGender' VALUES ('0','Male',NULL,NULL,'Male','he',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('1','Female',NULL,NULL,'Female','she',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('2','Transgender',NULL,NULL,'Transgender','it',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('3','Ungendered',NULL,NULL,'Ungendered','it',NULL,NULL,NULL,NULL);
            ")

        Dim VersionParts = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        Dim VersionNumber = ClarkTribeGames.Converters.GetVersion(Application.ProductVersion)

        'dbInfo
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbInfo' VALUES ('" & savename & "','" &
            VersionNumber & "');")

        'dbItemClass
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbItemClass' VALUES ('0','Handheld',NULL);
            INSERT INTO 'dbItemClass' VALUES ('1','Wearable',NULL);
            INSERT INTO 'dbItemClass' VALUES ('2','Charm',NULL);
            INSERT INTO 'dbItemClass' VALUES ('3','Item',NULL);
            INSERT INTO 'dbItemClass' VALUES ('4','Relic',NULL);
            ")

        'dbModi
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbModi' VALUES ('0','Strength','STR','Strength is how hard you hit something, how much you can carry, and how well you tend to do with strength based skill checks.');
            INSERT INTO 'dbModi' VALUES ('1','Dexterity','DEX','Dexterity determines speed. It is how fast you are, as well as how successful you are with ranged attacks.');
            INSERT INTO 'dbModi' VALUES ('2','Constitution','CON','Constitution is around your actual fortitude as a player. It is the stat that has a direct effect on your hit points, as well as your resistance to poisoning, how fast you sober up, and the likes.');
            INSERT INTO 'dbModi' VALUES ('3','Wisdom','WIS','Wisdom is knowing about the world around you as well as how perceptive you are. It determines what you naturally notice.');
            INSERT INTO 'dbModi' VALUES ('4','Intelligence','INT','Intelligence is how smart you are. It’s that simple really – Intelligence is usually academic intelligence – so how much you know about things.');
            INSERT INTO 'dbModi' VALUES ('5','Charisma','CHA','Charisma is how good you are with people. It is how good you are at persuading people you are a good guy or how well you get on with NPCs.');
            ")

        'dbProf
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbProf' VALUES ('0','Acrobatics','1','Your Acrobatics skill encompasses your ability to stay on your feet in a tricky situation.',NULL);
            INSERT INTO 'dbProf' VALUES ('1','Animal Handling','3','Animal Handling relates to checks with domesticated animals.',NULL);
            INSERT INTO 'dbProf' VALUES ('2','Arcana','4','Your Arcana skill reflects your knowledge in the realm of spells, magic items, eldritch symbols, magical traditions, the planes of existence, and the inhabitants of those planes.',NULL);
            INSERT INTO 'dbProf' VALUES ('3','Athletics','0','Athletics encompasses your ability to succeed in difficult situations you encounter while climbing, jumping, or swimming.',NULL);
            INSERT INTO 'dbProf' VALUES ('4','Deception','5','Your Deception skill encompasses your ability to convincingly hide the truth, either verbally or through your actions.  Persuasion is better than Deception.',NULL);
            INSERT INTO 'dbProf' VALUES ('5','History','4','Your History skill measures knowledge about historical events, legendary people, ancient kingdoms, past disputes, recent wars, and lost civilizations.',NULL);
            INSERT INTO 'dbProf' VALUES ('6','Insight','3','Your Insight skill encompasses your ability to read the true intentions of a creature, such as when searching out a lie or predicting someone’s next move.',NULL);
            INSERT INTO 'dbProf' VALUES ('7','Intimidation','5','When you attempt to influence someone through overt threats, hostile actions, and physical violence, this is when you make an Intimidation check.',NULL);
            INSERT INTO 'dbProf' VALUES ('8','Investigation','3','When you look around for clues and make deductions based on those clues, you make an Investigation check.',NULL);
            INSERT INTO 'dbProf' VALUES ('9','Medicine','3','Your Medicine skill encompasses your ability to stabilize a dying companion or diagnose an illness.',NULL);
            INSERT INTO 'dbProf' VALUES ('10','Nature','4','Your Nature skill measures your knowledge about terrain, plants and animals, the weather, and natural cycles.',NULL);
            INSERT INTO 'dbProf' VALUES ('11','Perception','3','Your Perception skill measures your ability to spot, hear, or otherwise detect the presence of something. It measures your general awareness of your surroundings and the keenness of your senses.',NULL);
            INSERT INTO 'dbProf' VALUES ('12','Performance','5','Your Performance skill determines how well you can delight an audience with music, dance, acting, storytelling, or some other form of entertainment.',NULL);
            INSERT INTO 'dbProf' VALUES ('13','Persuasion','5',' When you attempt to influence someone or a group of people with tact, social graces, or good nature, this is when you make a Persuasion check.  Persuasion is better than Deception.',NULL);
            INSERT INTO 'dbProf' VALUES ('14','Religion','4','Your Religion skill measures your knowledge about deities, rites and prayers, religious hierarchies, holy symbols, and the practices of secret cults.',NULL);
            INSERT INTO 'dbProf' VALUES ('15','Sleight of Hand','1','Sleight of Hand determines your ability to plant something on someone else without them knowing or to conceal an object on your person.',NULL);
            INSERT INTO 'dbProf' VALUES ('16','Stealth','1','Your Stealth skill measures your ability to conceal yourself from enemies, slink past guards, slip away without being noticed, or sneak up on someone without being seen or heard.',NULL);
            INSERT INTO 'dbProf' VALUES ('17','Survival','3','Your Survival skill encompasses your ability to survive in the treacherous wilderness.',NULL);
            INSERT INTO 'dbProf' VALUES ('18','Technology','3','Your Technology skill encompasses your ability to understand, repair, and analyze technology.',NULL);
            ")

        'dbSections
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbSections' VALUES ('0','0','Center Stage','1x1x2','1x1x2','0',NULL,'Center Stage Ground','0',NULL);
            INSERT INTO 'dbSections' VALUES ('1','0','North West','0x0x2','0x0x2','0',NULL,'North West Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('2','0','North Area','0x1x2','0x1x2','0',NULL,'North Area Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('3','0','North East','0x2x2','0x2x2','0',NULL,'North East Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('4','0','West Area','1x0x2','1x0x2','0',NULL,'West Area Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('5','0','East Area','1x2x2','1x2x2','0',NULL,'East Area Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('6','0','South West','2x0x2','2x0x2','0',NULL,'South West Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('7','0','South Area','2x1x2','2x1x2','0',NULL,'South Area Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('8','0','South East','2x2x2','2x2x2','0',NULL,'South East Ground','1',NULL);
            INSERT INTO 'dbSections' VALUES ('9','0','In The Air','0x0x1','2x2x1','0','blue','In the Air','1',NULL);
            INSERT INTO 'dbSections' VALUES ('10','0','Underground','0x0x3','2x2x3','0','brown','Underground','0',NULL);
            INSERT INTO 'dbSections' VALUES ('11','0','In Space','0x0x0','2x2x0','0','purple','In Space','0',NULL);
            INSERT INTO 'dbSections' VALUES ('12','0','In Hell','0x0x4','2x2x4','0','red','In Hell','0',NULL);
            ")

        'dbSize
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbSize' VALUES ('0','Micro','Less than 6 Inches : Under 1/8 lb.',NULL,'a Micro-Sized',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('1','Mini','Between 6 inches and 1 foot : Between 1/8 lb. and 1 lb.',NULL,'a Mini-Sized',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('2','Tiny','Between 1 foot and 2 feet : Between 1 lb. and 8 lbs.',NULL,'a Tiny',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('3','Small','Between 2 feet and 4 feet : Between 8 lbs. and 40 lbs.',NULL,'a Small',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('4','Average','Between 4 feet and 8 feet : Between 60 lbs. and 500 lbs.',NULL,'an Average-Sized',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('5','Large','Between 8 feet and 16 feet : 500 lbs. and 2 tons',NULL,'a Large',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('6','Huge','Between 16 feet and 32 feet : Between 2 tons and 16 tons',NULL,'a Huge',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('7','Enormous','Between 32 feet and 64 feet : Between 16 tons and 125 tons',NULL,'an Enormous',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('8','Ginormous','More than 64 foot : More than 125 tons',NULL,'a Ginormous',NULL,NULL,NULL,NULL);
            ")

        'dbStats
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbStats' VALUES ('0','HP','A number measuring the amount of damage a character can take before being killed, disabled or destroyed.  Factors in Constitution, Strength, and Dexterity.','2x0x1',NULL);
            INSERT INTO 'dbStats' VALUES ('1','MP','A number measuring the amount of power of a character to use special magical abilities or spells.  Factors in Constitution, Wisdom, and Intelligence.','2x3x4',NULL);
            INSERT INTO 'dbStats' VALUES ('2','AP','A number measuring the amount of attempts a character has to use their abilities.  Factors in Dexterity, Intelligence, and Wisdom.','1x4x5',NULL);
            INSERT INTO 'dbStats' VALUES ('3','Power','A number measuring the physical power of a character.  Factors in Strength and Constitution.','0x2',NULL);
            INSERT INTO 'dbStats' VALUES ('4','Defense','A number measuring the natural physical defense of a character.  Factors in Stength and Dexterity.','0x1',NULL);
            INSERT INTO 'dbStats' VALUES ('5','Mystic','A number measuring the magic intensity of a character.  Factors in Wisdom, Intelligence, and Charisma.','3x4x5',NULL);
            INSERT INTO 'dbStats' VALUES ('6','Will','A number measuring the mental strength of a character to maintain their composure.  Factors in Constitution, Wisdom, and Charisma.','2x3x5',NULL);
            INSERT INTO 'dbStats' VALUES ('7','Luck','A number measuring the amount of chance around a character.  Factors in Wisdom and Charisma.','3x5',NULL);
            INSERT INTO 'dbStats' VALUES ('8','Stamina','A number measuring how long a character can go if needed before needing to recover.  Factors in Constitution and Dexterity.','2x1',NULL);
            INSERT INTO 'dbStats' VALUES ('9','Speed','A number measuring how fast a character can perform a task or movement.  Factors in Dexterity and Constitution.','1x2',NULL);
            ")

        'dbStatus
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbStatus' VALUES ('0','Normal','green','All is good.','is in Normal Health','99','0',NULL);")

        'dbVerse
        ClarkTribeGames.SQLite.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbVerse' VALUES ('0','LimitlessVerse',
            'This is the LimitlessVerse where The Arena is located.',NULL,'1',NULL,NULL);")

        ClarkTribeGames.SQLite.CloseSQL(SavePath, savename & SaveExt)
    End Sub

End Class
