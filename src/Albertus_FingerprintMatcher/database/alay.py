import random

def HumanToABG(aseli, options):
    abgteks = aseli
    stemp = ""
    terganti = 0

    TabelHuruf = "AEGIOSZ"
    TabelAngka = "4361052"  # 01234567890
    TabelVokal = "AIUEO"

    if aseli:
        # Modifikasi huruf besar kecil
        if options[0]:
            for huruf in abgteks:
                acak = random.randint(0, 1)
                if acak:
                    stemp += huruf.lower()
                else:
                    stemp += huruf.upper()
            abgteks = stemp

        # Modifikasi huruf jadi angka
        stemp = ""
        if options[1]:
            for i, huruf in enumerate(abgteks):
                acak = random.randint(0, 1)
                terganti = 0
                if acak:
                    for j, huruf_tabel in enumerate(TabelHuruf):
                        if huruf.upper() == huruf_tabel:
                            stemp += TabelAngka[j]
                            terganti = 1
                            break
                if not terganti:
                    stemp += abgteks[i]
            abgteks = stemp
        
        # Disingkat-singkat biar pendek
        stemp = ""
        if options[2]:
            for i, huruf in enumerate(abgteks):
                acak = random.randint(0, 1)
                terganti = 0
                if acak:
                    for j, vokal in enumerate(TabelVokal):
                        if huruf.upper() == vokal:
                            if aseli[i - 1] != " " and i > 0:
                                terganti = 1
                            break
                if not terganti:
                    stemp += abgteks[i]
            abgteks = stemp

        return abgteks


# Example usage:
# input_string = str(input())
# options = [random.choice([True, False]) for i in range (3)]
# while True not in options:
#     options = [random.choice([True, False]) for i in range (3)]

# result = HumanToABG(input_string, options)
# print(result)


res = ['Nikolaos Kristoffersson', 'Bryn Hush', 'Angelique Culp', 'Tobye Coulthard', 'Kaila Blazey', 'Byrle Skyppe', 'Cory Chace', 'Coreen Peres', 'Ulises Sisse', 'Tibold Truckett', 'Baillie Eayres', 'Giulia Blodget', 'Reeba Venny', 'Delbert Amyes', 'Cindee Hitter', 'Rea Meininger', 'Araldo Hayward', 'Octavius Le Monnier', 'Mannie Agutter', 'Sofie Lupton', 'Olimpia Hymers', 'Emalia Bernadzki', 'Andrus Tyrer', 'Aldridge Copnar', 'Mariel Veal', 'Jodie Kiff', 'Lethia Giddons', 'Dudley Tomei', 'Kliment Chatteris', 'Kale Dreng', 'Hazel Boshard', 'Fowler Howick', 'Zorana Gilks', 'Heddi Clamp', 'Marjory Geaveny', 'Karyl Keneford', 'Ethan Gillan', 'Chelsae Savaage', 'Jeremie Keitley', 'Rodney Holtom', 'Sharity Klus', 'Benoit Carme', 'Vere Birdsall', 'Roddie Blois', 'Hyacinthie Meyrick', 'Englebert Lacroutz', 'Edouard Graundisson', 'Rosalyn Blacksland', 'Gabie Vanderson', 'Brockie O`Curneen', 'Malina Carefull', 'Maurizio Ivancevic', 'Chalmers Byrch', 'Bobinette Oakley', 'Kathi O`Hanlon', 'Alexis Clyne', 'Tamarra McGowing', 'Gene Nouch', 'Kim Menichillo', 'Millard Ferrarello', 'Jermain Giacopazzi', 'Lida Torel', 'Gwendolen Semper', 'Glen Clampton', 'Hardy Sealeaf', 'Adrianne Ridolfo', 'Costanza Spurdens', 'Ilyse Bugdell', 'De witt Grayne', 'Carey Roback', 'Rivi Balle', 'Granny Pickwell', 'Babs Woodings', 'Giovanni Whatmough', 'Jermayne Kemitt', 'Lisabeth Densey', 'Dina Ajam', 'Cleveland Worsnop', 'Jere Uebel', 'Caroline Cumo', 'Jackie Salzburg', 'Wallace Mee', 'Ransom Fones', 'Merilyn Le Cornu', 'Lauren Inold', 'Early Dries', 'Jeanette Kilpin', 'Danice MacGillespie', 'Jeramey Yusupov', 'Rivalee MacClenan', 'Noelle Najafian', 'Fiann Hruska', 'Kit McPharlain', 'Gibby Wilshere', 'Ilene Bartelot', 'Rosanna Seywood', 'Luisa Vicarey', 'Ty Allery', 'Marco Rosendahl', 'Sheba Nuzzi', 'Silvano Treffry', 'Essie Arnholdt', 'Field Wixey', 'Friedrick Joselson', 'Stavro Ionesco', 'Halley Dallimore', 'Thorsten Alesbrook', 'Tremain Ferraron', 'Bradly Mongin', 'Dixie Leyrroyd', 'Alessandra Filer', 'Ronalda Snookes', 'Lynnelle Fomichyov', 'Vail Boland', 'Tonnie Posthill', 'Mariann Greenhouse', 'Sam Gorioli', 'Shelton Ickovits', 'Jody Jerosch', 'Karoline Cotsford', 'Fanechka Aust', 'Daron McAne', 'Ashlee Rainsbury', 'Kennett Belone', 'Wilden Wogden', 'Ricky Sings', 'Scot Loton', 'Emylee Maudson', 'Arron Tullett', 'Isiahi Sifleet', 'Ina Duffy', 'Auria Guilbert', 'Audi Coy', 'Xenia Jacques', 'Kala Bachshell', 'Siouxie Whitten', 'Tilly Dymick', 'Benito Virr', 'Derron Lints', 'Willamina Vezey', 'Elbert Knoble', 'Rivi Stangoe', 'Agneta Kirkbright', 'Lilas Ruperti', 'Valera Levinge', 'Vivien Mallender', 'Camile Trobe', 'Aila Somerlie', 'Georgianne Bedward', 'Florenza Leatt', 'Stacee MacKegg', 'Kinsley Boorne', 'Aubry Kittman', 'Rheta Burkitt', 'Merridie Bridal', 'Roarke Haymes', 'Artair Hexum', 'Thatch MacAndreis', 'Saleem Moult', 'Emery Brymner', 'Claudetta Lawlings', 'Rodina Chrstine', 'Russ Guiu', 'Marline Bain', 'Susan Alwin', 'Toby Jalland', 'Alison Townley', 'Yelena Bazoge', 'Teodor Hagstone', 'Lorie Swadden', 'Linda Sidebotham', 'Linet Storrie', 'Luz Skures', 'Annabella Heasly', 'Nicolea Tambling', 'Chico Domegan', 'Glori Frake', 'Marje Dongall', 'Dunn Collar', 'Zechariah Petticrew', 'Mariele MacGillavery', 'Palmer McAvaddy', 'Marve MacKnocker', 'Urban Sergent', 'Thomas Shovelton', 'Charley Bouts', 'Daffy Gogarty', 'Charlotta Scolland', 'Sharron Plumbridge', 'Shoshanna Seally', 'Wanids Ugo', 'Jens Bayford', 'Vanny Taffley', 'Alden Dover', 'Daffi Phayre', 'Corabella Mews', 'Kaila Brissard', 'Elroy Scad', 'Nanci Heaney`', 'Felicia Craddy', 'Jenny Raffan', 'Lethia MacGill', 'Fernandina Colvine', 'Tobe Dulinty', 'Dexter Siddall', 'Linus Ibbitt', 'Maisey Breitler', 'Dottie Loseke', 'Inga Toppes', 'Matthieu Kilban', 'Kirk Giorgioni', 'Annabal Dewsnap', 'Brigit Tolcher', 'Michelle Seaman', 'Woodrow McKennan', 'Alphonse Jakubovicz', 'Ruddie Francey', 'Francois Danilowicz', 'Barty Kemet', 'Siward Hannum', 'Corinna Degoey', 'Salomon Werendell', 'Sianna Benedidick', 'Rhoda Grenkov', 'Daphene Lyston', 'Lorine Hansman', 'Flossi Poge', 'Reena Patten', 'Creighton Geaves', 'Jenny Lauridsen', 'Esteban Daykin', 'Evvie Boseley', 'Norris Burnitt', 'Layney Goldes', 'Fay Swatton', 'Waverly Costi', 'Jinny Goodnow', 'Doralia Cleverly', 'Carrissa Norcott', 'Vanny Knowler', 'Lewiss Longstreeth', 'Claude Driffill', 'Jone Hackett', 'Glenn Fairlem', 'Germain Proudley', 'Doralia Abotson', 'Karlotta Bagwell', 'Noah Narraway', 'Modesta Greenard', 'Dyana Benezet', 'Pearl Wattam', 'Carmine O`Deegan', 'Kris Vedikhov', 'Fina Mesias', 'Nonnah Sturdey', 'Ritchie Glanders', 'Isabelita Morrant', 'Dori Clifft', 'Doralin Grichukhanov', 'Dianne Brackenbury', 'Rafaellle Thickin', 'Antin Menco', 'Dorthea Nutkins', 'Margarette Ferrers', 'Georgianna Tames', 'Tate Van Eeden', 'Margalit Wratten', 'Jakob Genicke', 'Dorolisa Chesson', 'Aveline Le Friec', 'Pamelina Comar', 'Yolanthe Josipovitz', 'Elsi Wasiela', 'Hilliard Mille', 'Kenon De Lacey', 'Carey Astley', 'Kania Towner', 'Braden Twinborough', 'Silvester Redparth', 'Claire Ottewill', 'Joey Threadgold', 'Ninnette Kaplan', 'Lynnet Hendrick', 'Dorelia Bellany', 'Raff Stabler', 'Trstram Welman', 'Marten Camp', 'Port Chiverton', 'Camella Cranshaw', 'Giacobo Celand', 'Matias Jacobsson', 'Iormina Pydcock', 'Jaquith Upstone', 'Danielle Longmore', 'Broderick Rowe', 'Lindsy Linnock', 'Kirstyn Tevlin', 'Tandie Cutten', 'Nehemiah Squire', 'Stesha Goodread', 'Reginald Truelock', 'Demetris Armitt', 'Tiphani Reynard', 'Brok Sandell', 'Hakim Vakhonin', 'Olympia Strelitz', 'Anton Murfett', 'Alexis Duce', 'Austen Wardrop', 'Audrye Geeritz', 'Siegfried Renison', 'Dawn Brunel', 'Dione Pember', 'Bernice John', 'Anet Balfe', 'Jeffrey McGrory', 'Ruthann Faustian', 'Tatiania Bramstom', 'Normie Roulston', 'Madeleine Poff', 'Ellerey Tuppeny', 'Frannie Giacobo', 'Jolee Aldgate', 'Tally Whates', 'Dionisio Teenan', 'Jody Toner', 'Fleming Caven', 'Kasper Hulls', 'Gav Karpenko', 'Lorena Mashal', 'Vevay Gencke', 'Caesar Macrae', 'James Oakden', 'Benedetto Izachik', 'Shaughn Tabart', 'Jasmina Pavlenkov', 'Constantia Groger', 'Kylie Blackeby', 'Ashien Allen', 'Patsy Vannar', 'Susanetta Yezafovich', 'Donny Hort', 'Alysa Scain', 'Fremont Mainston', 'Wendeline Fomichkin', 'Rosene Burden', 'Rivy Mosedall', 'Chauncey Meakes', 'Dolf Attwell', 'Cornela Imloch', 'Orsola Northcliffe', 'Berty Fossey', 'Terrie Guiden', 'Barb McIllrick', 'Barton Teresse', 'Faith Strutt', 'Ardys Oughton', 'Dyanne McAvey', 'Kendell Lightman', 'Farah Restieaux', 'Micah Landsbury', 'Ahmed Marjanski', 'Carolus Sobtka', 'Eugenius Cuss', 'Teddy Dunkerly', 'Siouxie Geockle', 'Vitia Harme', 'Martguerita Puddicombe', 'Wilhelmina Corrett', 'Hale Maud', 'Eddie Hartgill', 'Antoinette Hardage', 'Gertie Huntriss', 'Stevena Hallor', 'Kaitlynn Pemble', 'Stinky Nardoni', 'Gusella Dain', 'Cordie Grayling', 'Rubia Boulton', 'Ellerey Thompsett', 'Aleen Partleton', 'Rafferty Classen', 'Tallia Niece', 'Calla Skeat', 'Lukas Addy', 'Meryl Skipperbottom', 'Holli Grenter', 'Maje Fullalove', 'Persis Kilbane', 'Lara Boar', 'Davine Crankhorn', 'Adina Gunney', 'Marcy Djorvic', 'Vaclav Casterot', 'Arnold Daborne', 'Alexa Jeffryes', 'Papageno Keetley', 'Louisette Rubinsohn', 'Abbe L`Hommee', 'Thekla Bickerdyke', 'Edita Shoebridge', 'Jill Weems', 'Emmey Harrowell', 'Talyah Filkov', 'Drusilla Gley', 'Delmer Bouts', 'Rab Baston', 'Antonie Gerrard', 'Buck Chezelle', 'Adan Schuler', 'Antonietta Authers', 'Torrence Scarsbrick', 'Evangelina Lingner', 'Ralina Ary', 'Kata Navarijo', 'Elfrieda Hollerin', 'Marlin Halhead', 'Dorey Castanho', 'Dud Selwin', 'Joelie Merwe', 'Myrle Leechman', 'Constantine Gorioli', 'Rudy Isham', 'Valle Bentley', 'Ray Gerdts', 'Iona Collins', 'Stanislaw Gallifont', 'Maurizia Ganter', 'Gerty Staggs', 'Sissie Scardefield', 'Gerrilee Gudde', 'Emlynn MacGillicuddy', 'Teodoro Happer', 'Kirk Stonnell', 'Aron Samett', 'Terence Mathou', 'Tulley Sambiedge', 'Raine Carlisle', 'Bonita Churm', 'Shelton Claris', 'Cariotta Legrice', 'Ignace Middis', 'Rheba Harg', 'Dreddy Robers', 'Caesar Essberger', 'Kit Libri', 'Wilhelmina Grenfell', 'Gwenora Fitzroy', 'Celesta Enterle', 'Edd Hrihorovich', 'Kirbie Heatlie', 'Lissi Minihane', 'Hetty Beadles', 'Marcelo Hallen', 'Massimo Catteroll', 'Mayne Piotrowski', 'Link Greendale', 'Jillana Henriquet', 'Yehudi Myers', 'Augustine Candwell', 'Neall McReedy', 'Miranda McCarrick', 'Wash Barfitt', 'Osbourne Harrowsmith', 'Francois Valentinuzzi', 'Fairlie Chisolm', 'Von Bielfeldt', 'Mack Lilleyman', 'Sonny Debrett', 'Palm Rapson', 'Tracee Barnsley', 'Mary Gloves', 'Pepito Dewdney', 'Cooper Fee', 'Olivette Duthy', 'Bevan Newsham', 'Rip Szymoni', 'Clara Benoist', 'Emmett Pashba', 'Stanton Engel', 'Catlin Greedy', 'Lloyd Gillebert', 'Dannie Fossick', 'Jaye Raddin', 'Claretta Chieze', 'Berky Trevaskiss', 'Ewell Civitillo', 'Lorelei Perle', 'Cynthia Colnett', 'Candida Poinsett', 'Janene Frowd', 'Dottie Bullen', 'Roda Brundle', 'Collin Padefield', 'Lemmy Barkes', 'Briny Turton', 'Salvidor Brower', 'Rosetta Curness', 'Guilbert Dunphy', 'Herve Shankle', 'Riannon O`Regan', 'Clary Dovidian', 'Sophey Sandwith', 'Marika Dowda', 'Reine Labon', 'Ursola Widdop', 'Lark Glynne', 'Jonathon Weatherburn', 'Dael Claris', 'Robinia Van den Bosch', 'Reena Dombrell', 'Bethena Severwright', 'Gabriell Arlt', 'Shermy Jermin', 'Jolynn Stamp', 'Courtenay Fursland', 'Roz Duker', 'Tremaine Leppington', 'Erika Askem', 'Adore Frary', 'Brandie Highman', 'Natale Emnoney', 'Chelsie Gascone', 'Teressa Boake', 'Alicea Morden', 'Devin Elverston', 'Tish Dobey', 'Catarina Keely', 'Rudy Mattiello', 'Vick Warde', 'Albertina Helsby', 'Carolan Nacci', 'Saul Hetterich', 'Kit Settle', 'Kayla Metzel', 'Gertrude Heritege', 'Levon Billham', 'Stefa Woodhall', 'Camellia Acock', 'Melinde Tremolieres', 'Lindsy McWaters', 'Brock Bernardot', 'Marquita Serotsky', 'Brynna Rigard', 'Elisha Gillatt', 'Vincent O`Day', 'Myrtice Woffenden', 'Dukey Brimilcombe', 'Nevins Loyley', 'Salomo Gehricke', 'Joete Trimble', 'Lita Fackrell', 'Delila Atter', 'Verna Raithbie', 'Tamarra Guyver', 'Aldon Ojeda', 'Roarke Tafani', 'Wilden Arger', 'Myca Forster', 'Jannel McPhilip', 'Chaim Marron', 'Raphael Colvine', 'Tandy Duckering', 'Chad Menlow', 'Wilhelmina Woloschinski', 'Nico Baldery', 'Mychal Arger', 'Rose Chadbourn', 'Gawen Rodliff', 'Reider Rembaud', 'Alexandro Harley', 'Lela Baird', 'Katrine Surman', 'Dorelia Rosenstiel', 'Feodor Assaf', 'Iver Honatsch', 'Dani Halse', 'Demetre Bicheno', 'Weylin Toun', 'Monte Shevelin', 'Pace De Few', 'Quintina Lenaghen', 'Roseann Rosling', 'Darline Duly', 'Nolana Greber', 'Virginia Charters', 'Mella Tilson', 'Anastasia Gillean', 'Morris Zisneros', 'Kit Lappine', 'Viki Wardingly', 'Cam Elkin', 'Pammy Wheeliker', 'Emeline Soppeth', 'Randal Thorne', 'Curt Wharrier', 'Giffy Jirka', 'Skye Torri', 'Xena Esselen', 'Josie Reaman']
# print(len(res))