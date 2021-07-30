Public Class Database

    Public Shared SavePath As String = MemoryBank.DataDir & "\"
    Public Shared DefaultSave As String = Settings.SettingsDefaultDB
    Public Shared SaveExt As String = "." & MemoryBank.SavesExt


    Public Shared Sub CheckForDB(savename As String)
        DefaultSave = Settings.SettingsDefaultDB
        Dim DBExists As Boolean = System.IO.File.Exists(SavePath & savename & SaveExt),
            DefaultExists As Boolean = System.IO.File.Exists(SavePath & DefaultSave & SaveExt)
        If DBExists Then
            MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(savename)
            MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(savename)
        Else
            If DefaultExists Then
                MsgBox(Converters.UppercaseEachFirstLetter(savename) & " not available.  Switching to " &
                   Converters.UppercaseEachFirstLetter(DefaultSave) & ".")
                DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                    "lastdb", {"settingConfig"}, {DefaultSave})
                Settings.SettingsLastDB = LCase(DefaultSave)
                MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
                MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
            Else
                If savename = DefaultSave Then
                    MsgBox(Converters.UppercaseEachFirstLetter(savename) & " not available.  Generating a new " &
                    Converters.UppercaseEachFirstLetter(DefaultSave) & " Database.")
                Else
                    MsgBox(Converters.UppercaseEachFirstLetter(savename) & " and " &
                    Converters.UppercaseEachFirstLetter(DefaultSave) & " not available.  Generating a new " &
                    Converters.UppercaseEachFirstLetter(DefaultSave) & " Database.")
                End If
                CreateEmptyDB(Converters.UppercaseEachFirstLetter(DefaultSave))
                DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                    "defaultdb", {"settingConfig"}, {DefaultSave})
                DBTools.UpdateData(Settings.SettingsPath, Settings.SettingsName, "mainSettings", "settingName",
                    "lastdb", {"settingConfig"}, {DefaultSave})
                Settings.SettingsLastDB = LCase(DefaultSave)
                Settings.SettingsDefaultDB = LCase(DefaultSave)
                MainWindow.EditorDBText.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
                MainWindow.EditorSwitchCurBox.Text = Converters.UppercaseEachFirstLetter(DefaultSave)
            End If
        End If
    End Sub

    Public Shared Function GetDBName(savename As String) As String
        Return DBTools.GetCol(MemoryBank.DataDir, savename, "dbInfo", "dbName").Split(",")(0)
    End Function

    Public Shared Sub CreateEmptyDB(savename As String)
        DBTools.CreateDB(SavePath, savename & SaveExt, "
            CREATE TABLE 'dbInfo' ('dbName' TEXT NOT NULL, 'dbVersion' TEXT NOT NULL);
            CREATE TABLE 'dbToons' ('toonID' TEXT NOT NULL, 'toonName' TEXT NOT NULL, 'toonUID' TEXT NOT NULL,
            'toonRace' TEXT NOT NULL, 'toonClass' TEXT NOT NULL, 'toonAlign' TEXT NOT NULL, 'toonGender' TEXT NOT NULL, 
            'toonAge' TEXT NOT NULL, 'toonStartLv' TEXT NOT NULL, 'toonBio' TEXT NOT NULL, 'toonImage' TEXT NOT NULL, 
            'toonAbl' TEXT NOT NULL, 'toonEff' TEXT NOT NULL, 'toonHeld' TEXT NOT NULL, 'toonWear' TEXT NOT NULL, 
            'toonCharms' TEXT NOT NULL, 'toonInv' TEXT NOT NULL, 'toonForce' TEXT NOT NULL, 'toonAlias'  TEXT NOT NULL, 
            'toonDestiny' TEXT NOT NULL, 'toonTheme' TEXT NOT NULL);
            CREATE TABLE 'dbRace' ('raceID' TEXT NOT NULL, 'raceName' TEXT NOT NULL, 'raceDesc' TEXT, 
            'raceSize' TEXT NOT NULL, 'raceGender' TEXT NOT NULL, 'raceAge' TEXT NOT NULL, 'raceStats' TEXT NOT NULL, 
            'raceBio' TEXT NOT NULL, 'raceAbl' TEXT, 'raceEff' TEXT, 'raceAblType' TEXT, 'raceForce' TEXT);
            CREATE TABLE 'dbClass' ('classID' TEXT NOT NULL, 'className' TEXT NOT NULL, 'classDesc' TEXT, 
            'classStats' TEXT NOT NULL, 'classBio' TEXT NOT NULL, 'classAbl' TEXT, 'classEff' TEXT, 'classAblType' TEXT);
            CREATE TABLE 'dbSize' ('sizeID' TEXT NOT NULL, 'sizeName' TEXT NOT NULL, 'sizeDesc' TEXT, 
            'sizeStats' TEXT, 'sizeBio' TEXT NOT NULL, 'sizeAbl' TEXT, 'sizeEff' TEXT);
            CREATE TABLE 'dbAlign' ('alignID' TEXT NOT NULL, 'alignName' TEXT NOT NULL, 'alignDesc' TEXT, 
            'alignRank' TEXT NOT NULL, 'alignStats' TEXT, 'alignRep' TEXT NOT NULL, 'alignBio' TEXT NOT NULL, 
            'alignAbl' TEXT, 'alignEff' TEXT, 'alignAblType' TEXT, 'alignCode' TEXT);
            CREATE TABLE 'dbGender' ('genderID' TEXT NOT NULL, 'genderName' TEXT NOT NULL, 'genderDesc' TEXT, 
            'genderStats' TEXT, 'genderBio' TEXT NOT NULL, 'genderPro' TEXT NOT NULL, 'genderAbl' TEXT, 'genderEff' TEXT,
            'genderAblType' TEXT, 'genderCode' TEXT);
            CREATE TABLE 'dbAge' ('ageID' TEXT NOT NULL, 'ageName' TEXT NOT NULL, 'ageCriteria' TEXT NOT NULL, 
            'ageDesc' TEXT NOT NULL, 'ageCode' TEXT);
            CREATE TABLE 'dbAbl' ('ablID' TEXT NOT NULL, 'ablName' TEXT NOT NULL, 'ablDesc' TEXT, 'ablType' TEXT NOT NULL, 
            'ablCost' TEXT NOT NULL, 'ablTarget' TEXT NOT NULL, 'ablImpact' TEXT NOT NULL, 'ablBase' TEXT NOT NULL, 
            'ablElem' TEXT, 'ablEff' TEXT, 'ablChance' TEXT);
            CREATE TABLE 'dbAblType' ('abltypeID' TEXT NOT NULL, 'abltypeName' TEXT NOT NULL, 'abltypeCode' TEXT);
            CREATE TABLE 'dbEff' ('effID' TEXT NOT NULL, 'effName' TEXT NOT NULL, 'effDesc' TEXT, 'effType' TEXT NOT NULL, 
            'effCriteria' TEXT, 'effImpact' TEXT, 'effIncRate' TEXT, 'effElemAbs' TEXT, 'effElemPos' TEXT, 
            'effElemNeg' TEXT, 'effReflect' TEXT, 'effTeamMod' TEXT, 'effAlignMod' TEXT, 'effGenderMod' TEXT, 
            'effRaceMod' TEXT, 'effSizeMod' TEXT, 'effBio' TEXT, 'effCode' TEXT);
            CREATE TABLE 'dbEffType' ('efftypeID' TEXT NOT NULL, 'efftypeName' TEXT NOT NULL, 'efftypeDesc' TEXT,
            'efftypeCode' TEXT);
            CREATE TABLE 'dbItems' ('itemID' TEXT NOT NULL, 'itemName' TEXT NOT NULL, 'itemDesc' TEXT, 
            'itemClass' TEXT NOT NULL,'itemType' TEXT NOT NULL, 'itemSizeR' TEXT, 'itemRaceR' TEXT, 'itemClassR' TEXT, 
            'itemEffR' TEXT, 'itemAlignR' TEXT, 'itemStats' TEXT, 'itemBio' TEXT, 'itemAbl' TEXT, 'itemEff' TEXT, 
            'itemElement' TEXT, 'itemCode' TEXT);
            CREATE TABLE 'dbItemType' ('itemtypeID' TEXT NOT NULL, 'itemtypeName' TEXT NOT NULL, 'itemtypeClass' TEXT NOT NULL,
            'itemtypeCode' TEXT NOT NULL);
            CREATE TABLE 'dbItemClass' ('itemclassID' TEXT NOT NULL, 'itemclassname' TEXT NOT NULL, 
            'itemclassCode' TEXT);
            CREATE TABLE 'dbForce' ('forceID' TEXT NOT NULL, 'forceName' TEXT NOT NULL, 'forceText' TEXT NOT NULL, 
            'forceObtain' TEXT NOT NULL, 'forceOwner' TEXT NOT NULL, 'forceDesc' TEXT, 'forceCode' TEXT);
            CREATE TABLE 'dbAlias' ('aliasID' TEXT NOT NULL, 'aliasName' TEXT NOT NULL, 'aliasType' TEXT NOT NULL, 
            'aliasRace' TEXT NOT NULL,'aliasAlign' TEXT NOT NULL, 'aliasGender' TEXT NOT NULL, 'aliasJob' TEXT, 
            'aliasBio' TEXT, 'aliasImage' TEXT, 'aliasKnown' TEXT);
            CREATE TABLE 'dbDestiny' ('destinyID' TEXT NOT NULL, 'destinyName' TEXT NOT NULL, 'destinyDesc' TEXT, 
            'destinyCode' TEXT);
            CREATE TABLE 'dbEnviro' ('enviroID' TEXT NOT NULL, 'enviroName' TEXT NOT NULL, 'enviroEff' TEXT, 'enviroDesc' TEXT, 
            'enviroCode' TEXT);
            CREATE TABLE 'dbGeneric' ('genericID' TEXT NOT NULL, 'genericName' TEXT NOT NULL, 'genericRace' TEXT NOT NULL, 
            'genericClass' TEXT NOT NULL, 'genericAlignMin' TEXT NOT NULL, 'genericAlignMax' TEXT NOT NULL, 
            'genericGender' TEXT NOT NULL, 'genericMinLv' TEXT NOT NULL, 'genericMaxLv' TEXT NOT NULL, 
            'genericBio' TEXT, 'genericImage' TEXT, 'genericAbl' TEXT, 'genericEff' TEXT, 'genericHeld' TEXT, 
            'genericWear' TEXT, 'genericCharms' TEXT, 'genericInv' TEXT, 'genericMax' TEXT);
            CREATE TABLE 'dbJobs' ('jobID' TEXT NOT NULL, 'jobName' TEXT NOT NULL, 'jobRace' TEXT, 'jobClass' TEXT, 
            'jobBio' TEXT NOT NULL, 'jobHeld' TEXT, 'jobWear' TEXT, 'jobCharms' TEXT, 'jobInv' TEXT, 'jobCode' TEXT);
            CREATE TABLE 'dbStatus' ('statusID' TEXT NOT NULL, 'statusName' TEXT NOT NULL, 'statusColor' TEXT NOT NULL, 
            'statusDesc' TEXT NOT NULL, 'statusBio' TEXT NOT NULL, 'statusEffRank' TEXT NOT NULL, 'statusEff' TEXT NOT NULL);
            CREATE TABLE 'dbArenas' ('arenaID' TEXT NOT NULL, 'arenaName' TEXT NOT NULL, 'arenaVerse' TEXT NOT NULL, 
            'arenaDesc' TEXT,'arenaX' TEXT NOT NULL, 'arenaY' TEXT NOT NULL, 'arenaZ' TEXT NOT NULL, 'arenaActive' TEXT NOT NULL, 
            'arenaSpace' TEXT NOT NULL,'arenaHell' TEXT NOT NULL, 'arenaUnder' TEXT NOT NULL, 'areanCeiling' TEXT NOT NULL);
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
            'relationActive' TEXT NOT NULL);
            "
            )
        'Toon:      UID 0:Normal,1:Generic,2:Split,3:Clone,4:Variant,5:Twin,6:Shapeshifter,7:Alternative
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

        'Add Default Tables
        'dbAge
        DBTools.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAge' VALUES ('0','Baby','<1 or 2%','Newborn to very young',NULL);
            INSERT INTO 'dbAge' VALUES ('1','Adolescent','>=1 and <12%','Child age to teenager',NULL);
            INSERT INTO 'dbAge' VALUES ('2','Youthful','>=12% and <20%','Early Adult Life',NULL);
            INSERT INTO 'dbAge' VALUES ('3','Young','>=20% and <30%','Young Adult, Starting to Mature',NULL);
            INSERT INTO 'dbAge' VALUES ('4','Mid-Aged','>=30% and <50%','Middle of Life',NULL);
            INSERT INTO 'dbAge' VALUES ('5','Old','>=50% and <80%','Past Prime, Starting to Show Age',NULL);
            INSERT INTO 'dbAge' VALUES ('6','Elder','>=80% and <200','Late Stage of Life, Very Aged',NULL);
            INSERT INTO 'dbAge' VALUES ('7','Ancient','>=85% and >200','Centuries Old',NULL);
            "
            )
        'dbAlign
        DBTools.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbAlign' VALUES ('0','Lawful Good','Always does the right thing no matter what','100',NULL,'4','a Lawful Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('1','Neutral Good','Does right but never takes a side','87',NULL,'3','a Neutral Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('2','Chaotic Good','Does the right thing but at any means necessary','75',NULL,'2','a Chaotic Good',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('3','Lawful Neutral','Good with a dash of grey','63',NULL,'1','a Lawful Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('4','True Neutral','In the middle','50',NULL,'0','a True Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('5','Chaotic Neutral','Chooses the dark path but does not take sides','37',NULL,1,'a Chaotic Neutral',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('6','Lawful Evil','The law but does things dark','25',NULL,'2','a Lawful Evil',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('7','Neutral Evil','Bad in a sense but not all the way dark','13',NULL,'3','a Neutral Evil',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbAlign' VALUES ('8','Chaotic Evil','Chaos makes this one happy','0',NULL,'4','a Chaotic Evil',NULL,NULL,NULL,NULL);
            "
            )

        'dbArenas
        DBTools.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbArenas' VALUES ('0','The Arena','0',
            'This is the default arena.','3','3','3','1','1','1','5','0');")

        'dbElements
        DBTools.RunSQL(SavePath, savename & SaveExt, "
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
            "
            )

        'dbEnviro
        DBTools.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbEnviro' VALUES ('0','Normal',NULL,'Everything is Normal.',NULL);")

        'dbGender
        DBTools.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbGender' VALUES ('0','Male',NULL,NULL,'Male','he',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('1','Female',NULL,NULL,'Female','she',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('2','Transgender',NULL,NULL,'Transgender','it',NULL,NULL,NULL,NULL);
            INSERT INTO 'dbGender' VALUES ('3','Ungendered',NULL,NULL,'Ungendered','it',NULL,NULL,NULL,NULL);
            "
            )

        Dim VersionParts = Strings.Split((System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()), ".", 4)
        Dim VersionNumber = VersionParts(0) & "." & VersionParts(1) & "." & Converters.VersionConverter(VersionParts(2), 3) & "." & Converters.VersionConverter(VersionParts(3), 4)

        'dbInfo
        DBTools.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbInfo' VALUES ('" & savename & "','" &
            VersionNumber & "');")

        'dbItemClass
        DBTools.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbItemClass' VALUES ('0','Handheld',NULL);
            INSERT INTO 'dbItemClass' VALUES ('1','Wearable',NULL);
            INSERT INTO 'dbItemClass' VALUES ('2','Charm',NULL);
            INSERT INTO 'dbItemClass' VALUES ('3','Item',NULL);
            INSERT INTO 'dbItemClass' VALUES ('4','Relic',NULL);
            "
            )

        'dbSections
        DBTools.RunSQL(SavePath, savename & SaveExt, "
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
            "
            )

        'dbSize
        DBTools.RunSQL(SavePath, savename & SaveExt, "
            INSERT INTO 'dbSize' VALUES ('0','Micro','Less than 6 Inches : Under 1/8 lb.',NULL,'a Micro-Sized',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('1','Mini','Between 6 inches and 1 foot : Between 1/8 lb. and 1 lb.',NULL,'a Mini-Sized',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('2','Tiny','Between 1 foot and 2 feet : Between 1 lb. and 8 lbs.',NULL,'a Tiny',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('3','Small','Between 2 feet and 4 feet : Between 8 lbs. and 40 lbs.',NULL,'a Small',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('4','Average','Between 4 feet and 8 feet : Between 60 lbs. and 500 lbs.',NULL,'an Average-Sized',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('5','Large','Between 8 feet and 16 feet : 500 lbs. and 2 tons',NULL,'a Large',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('6','Huge','Between 16 feet and 32 feet : Between 2 tons and 16 tons',NULL,'a Huge',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('7','Enormous','Between 32 feet and 64 feet : Between 16 tons and 125 tons',NULL,'an Enormous',NULL,NULL);
            INSERT INTO 'dbSize' VALUES ('8','Ginormous','More than 64 foot : More than 125 tons',NULL,'a Ginormous',NULL,NULL);
            "
            )

        'dbVerse
        DBTools.RunSQL(SavePath, savename & SaveExt, "INSERT INTO 'dbVerse' VALUES ('0','LimitlessVerse',
            'This is the LimitlessVerse where The Arena is located.',NULL,'1',NULL,NULL);")

    End Sub

End Class
