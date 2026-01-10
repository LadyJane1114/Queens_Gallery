using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Queens_Gallery.Models;

namespace Queens_Gallery
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Models.CarouselItem> Portraits { get; set; }

        private const int VisibleCount = 5;
        private int _currentCenterIndex = 0;

        public ObservableCollection<Models.CarouselItem> VisiblePortraits { get; } = new ObservableCollection<Models.CarouselItem>();

        public MainWindow()
        {
            InitializeComponent();

            Portraits = new ObservableCollection<CarouselItem>
            {
                new CarouselItem
                {
                    Title = "Mary Shelley",
                    ImagePath = "resources/m-shelley.jpg",
                    Subtitle ="The Mother of Science Fiction",
                    ActiveEra ="Early 19th Century CE",
                    PrimaryLocation="London, England",
                    InfoBlurb="Mary Shelley was a pioneering novelist whose imagination brought forth 𝘍𝘳𝘢𝘯𝘬𝘦𝘯𝘴𝘵𝘦𝘪𝘯, a story that continues to shape the landscape of science fiction and modern myth. She began writing the novel at just eighteen years old, during a legendary gathering of writers that included Percy Bysshe Shelley and Lord Byron, where a friendly ghost-story challenge sparked one of the most enduring works in literary history. What emerged was far more than a tale of horror—it was a profound meditation on creation, responsibility, and the fragile line between human ambition and moral consequence. Through her work, Shelley explored the emotional and ethical costs of innovation, securing her place not only as a founder of science fiction, but as one of the most intellectually daring voices of the Romantic era.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Hattie McDaniel",
                    ImagePath = "resources/hattie-mcdaniel.jpg",
                    Subtitle ="The Woman who Broke Hollywood's First Barrier",
                    ActiveEra ="1930s-1950s CE",
                    PrimaryLocation="Hollywood, California",
                    InfoBlurb="Hattie McDaniel became the first Black person to win an Academy Award for her unforgettable performance in 𝘎𝘰𝘯𝘦 𝘸𝘪𝘵𝘩 𝘵𝘩𝘦 𝘞𝘪𝘯𝘥, a historic achievement that forever changed Hollywood. Yet the triumph was shadowed by the racial barriers of her time—she was forced to sit apart from her fellow cast members at the segregated ceremony, a painful reminder that recognition did not mean equality. Despite the limitations placed on her career, McDaniel used her success to open doors for future Black performers, insisting on dignity, professionalism, and visibility in an industry that often denied all three. Her legacy is not only one of artistic excellence, but of quiet defiance against a system that tried to diminish her worth.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Anne Bonny and Mary Read",
                    ImagePath = "resources/anne-and-mary.jpg",
                    Subtitle ="The Queens of the Caribbean",
                    ActiveEra ="Early 18th Century CE",
                    PrimaryLocation="Caribbean Sea",
                    InfoBlurb="Anne Bonny and Mary Read rose to infamy as two of the most daring pirates ever to sail the Caribbean, carving out a place for themselves in a brutal, male-dominated world of crime and conquest. Sailing under Jack Rackham aboard ships such as the 𝘙𝘦𝘷𝘦𝘯𝘨𝘦, they fought with such skill and ferocity that even their enemies took notice. Their partnership was so close that many historians believe they were lovers as well as comrades, a bond forged through danger, secrecy, and defiance. When Rackham was captured and sentenced to death, Anne reportedly scorned him with the words, “If you had fought like a man, you would not have to die like a dog,” a line that has echoed through pirate lore ever since. Their story endures not merely as piracy, but as a radical claim to freedom, identity, and self-determination.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Jane Austen",
                    ImagePath = "resources/jane-austen.jpg",
                    Subtitle ="The Sovereign of Social Satire",
                    ActiveEra ="Late 18th - Early 19th Century CE",
                    PrimaryLocation="Hampshire, England",
                    InfoBlurb="Jane Austen chronicled the manners, morals, and romantic entanglements of her society with a wit so sharp it still cuts two centuries later. Through novels such as 𝘗𝘳𝘪𝘥𝘦 𝘢𝘯𝘥 𝘗𝘳𝘦𝘫𝘶𝘥𝘪𝘤𝘦 and 𝘚𝘦𝘯𝘴𝘦 𝘢𝘯𝘥 𝘚𝘦𝘯𝘴𝘪𝘣𝘪𝘭𝘪𝘵𝘺, she offered a precise and often quietly radical portrait of the English gentry, exposing how class, money, and reputation shaped women’s lives. Though her novels are frequently dismissed as mere romances—a bias that has long haunted women’s writing—they are in fact sophisticated studies of power, social mobility, and moral integrity. Austen’s keen observations of human behavior allow her work to function as both intimate love stories and enduring historical records of a society in transition.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Boudica",
                    ImagePath = "resources/bouddica.jpg",
                    Subtitle ="The Flame of Britannia",
                    ActiveEra ="1st Century CE",
                    PrimaryLocation="Iceni Territory, England",
                    InfoBlurb="Boudica, queen of the Iceni tribe, led one of the most formidable uprisings against Roman rule in ancient Britain. After Roman officials flogged her and assaulted her daughters, she united multiple Celtic tribes and launched a campaign that razed Roman strongholds including Camulodunum (modern Colchester), Londinium, and Verulamium. Though her rebellion was ultimately crushed by Rome’s military might, her leadership revealed the vulnerability of even the most powerful empire when faced with collective resistance. Across centuries, Boudica has endured as a symbol of defiance, a woman who refused to accept injustice and whose name still stirs the imagination of those who resist domination and fight for self-determination.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Ada Lovelace",
                    ImagePath = "resources/ada-love.jpg",
                    Subtitle ="Enchantress of Numbers",
                    ActiveEra ="Mid 19th Century CE",
                    PrimaryLocation="London, England",
                    InfoBlurb="Ada Lovelace fused mathematical brilliance with poetic imagination to envision a future no one else could yet see. She wrote what is now recognized as the first computer algorithm, realizing that machines could do far more than calculate numbers — they could manipulate symbols, create patterns, and even compose music. The daughter of Lord Byron, she was deliberately educated in mathematics and science by her mother, who hoped to shield her from what she called her father’s “poetic madness,” yet Ada instead became the rare mind who bridged logic and creativity. Today, she is honored as the first computer programmer, and Ada Lovelace Day — celebrated on the second Tuesday of October — recognizes women in STEM whose work continues her legacy of visionary thinking.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Joan of Arc",
                    ImagePath = "resources/st-joan-of-arc.jpg",
                    Subtitle ="The Maid of Orléans",
                    ActiveEra ="Early 15th Century CE",
                    PrimaryLocation="France",
                    InfoBlurb="Joan of Arc, barely 19 years old, rose to command French forces during the Hundred Years’ War, demonstrating a courage and strategic insight far beyond her years. Guided by her unwavering faith, she inspired soldiers and civilians alike, leading key victories that turned the tide for France. Captured by the English and tried for heresy, Joan refused to renounce her visions or her mission, even in the face of death. She was burned at the stake, yet her conviction and heroism elevated her to the status of national icon and eventually canonization, leaving a legacy of bravery, faith, and resilience that continues to inspire people today.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Frida Kahlo",
                    ImagePath = "resources/frida.jpg",
                    Subtitle ="The Painted Soul of Mexico",
                    ActiveEra ="1920s-1950s CE",
                    PrimaryLocation="Mexico",
                    InfoBlurb="Frida Kahlo transformed pain into art, turning the hardships of her body and heart into vivid, unforgettable images. A devastating accident in her youth left her with chronic injuries, but it also became the lens through which she examined suffering, mortality, and personal strength. Rooted in Mexican traditions, folklore, and indigenous culture, her paintings often combine surrealism with intense symbolism, making the personal universal. Kahlo’s work endures as a testament to resilience, identity, and the unbreakable human spirit, influencing artists and admirers across the globe.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Hedy Lamarr",
                    ImagePath = "resources/hedy.jpg",
                    Subtitle ="The Star who Invented the Future",
                    ActiveEra ="1930s-1950s CE",
                    PrimaryLocation="Hedy Lamarr’s life was a striking blend of glamour and genius. Growing up Jewish in Austria as fascism loomed, she experienced the turbulence of pre-war Europe firsthand, an environment that shaped her resilience and ingenuity. After fleeing to America, she became a Hollywood star, captivating audiences with her talent and beauty. Yet behind the camera, Lamarr’s inventive mind thrived: she co-developed a frequency-hopping system to make radio-guided torpedoes secure from enemy interference. Though her scientific contributions were largely overlooked in her lifetime, they became essential to modern wireless communications, including Wi-Fi and Bluetooth, demonstrating that Lamarr’s brilliance transcended both screen and stage.",
                    InfoBlurb="",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Helen Keller",
                    ImagePath = "resources/Keller_Helen.jpg",
                    Subtitle ="The Voice that Conquered Silence",
                    ActiveEra ="Late 19th - Early 20th Century CE",
                    PrimaryLocation="Boston, Massachusetts",
                    InfoBlurb="Helen Keller overcame the immense challenges of being both deaf and blind to become one of the most influential voices for education, equality, and social justice. With the guidance of her teacher Anne Sullivan, Keller learned to communicate, eventually mastering language in ways that allowed her to write, lecture, and advocate worldwide. She campaigned tirelessly for the rights of people with disabilities, as well as for women’s suffrage, labor reforms, and pacifism, demonstrating that determination and intellect could triumph over extraordinary obstacles. Her life story continues to inspire generations to push past limitations and champion the power of human potential.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Zora Neale Hurston",
                    ImagePath = "resources/Zora-Neale-Hurston.jpg",
                    Subtitle ="The Storyteller of Black America",
                    ActiveEra ="1920s-1950s CE",
                    PrimaryLocation="Eatonville, Florida",
                    InfoBlurb="Zora Neale Hurston captured the rhythms, traditions, and voices of African-American life in the South, preserving folklore and cultural heritage that might have otherwise been lost. As a novelist, essayist, and anthropologist, she brought authenticity and vibrancy to her work, blending narrative art with meticulous ethnographic research. Hurston’s writing, including the celebrated novel Their Eyes Were Watching God, became central to the Harlem Renaissance, giving voice to African-American experiences with humor, wisdom, and dignity. Her legacy continues to influence literature, cultural studies, and social thought, ensuring that her people’s stories remain alive and celebrated.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Mary Wollstonecraft",
                    ImagePath = "resources/m-wollestoncraft.jpg",
                    Subtitle ="The Pen that Defied the Patriarchy",
                    ActiveEra ="Late 18th Century CE",
                    PrimaryLocation="London, England",
                    InfoBlurb="Mary Wollstonecraft was a pioneering advocate for women’s education and equality, challenging societal norms at a time when women were largely excluded from intellectual and professional life. Her landmark work, 𝘈 𝘝𝘪𝘯𝘥𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘰𝘧 𝘵𝘩𝘦 𝘙𝘪𝘨𝘩𝘵𝘴 𝘰𝘧 𝘞𝘰𝘮𝘢𝘯, called for reason, independence, and education for women, laying the intellectual foundation for modern feminism. Beyond her writings, Wollstonecraft’s ideals resonated in her personal life, influencing her daughter, Mary Shelley, whose own groundbreaking literary achievements were nurtured in a household committed to questioning conventions and valuing the power of the mind. Wollstonecraft’s courage and vision continue to inspire generations advocating for equality and social justice.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Hypatia of Alexandria",
                    ImagePath = "resources/hypatia.jpg",
                    Subtitle ="The Keeper of the Ancient Flame",
                    ActiveEra ="4th-5th Century CE",
                    PrimaryLocation="Alexandria, Egypt",
                    InfoBlurb="Hypatia of Alexandria was a brilliant mathematician, astronomer, and philosopher in late antiquity, renowned for her intellect and dedication to learning. She taught students from across the Mediterranean, wrote commentaries on mathematics and astronomy, and became a respected voice in philosophical debates of her time. Living in a period of political and religious turmoil, Hypatia’s unwavering commitment to reason and knowledge ultimately led to her tragic murder, making her a symbol of both the heights of classical learning and the fragility of human progress. Her legacy endures as an inspiration to scholars, particularly women in science and philosophy, who continue to push the boundaries of knowledge against societal constraints.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Murasaki Shikibu",
                    ImagePath = "resources/murasaki-shikibu.jpg",
                    Subtitle ="The Mother of the Novel",
                    ActiveEra ="11th Century CE",
                    PrimaryLocation="Kyoto, Japan",
                    InfoBlurb="Murasaki Shikibu, a court lady of Heian-era Japan, authored 𝘛𝘩𝘦 𝘛𝘢𝘭𝘦 𝘰𝘧 𝘎𝘦𝘯𝘫𝘪, often celebrated as the world’s first novel. Through her intricate portrayal of court life, she explored love, ambition, jealousy, and the fleeting nature of human happiness, revealing the complex social dynamics of her time. Her keen observations and poetic prose have allowed generations to glimpse the aesthetic and emotional sensibilities of early Japanese aristocracy. Murasaki’s work not only established a literary tradition but also set a standard for psychological depth and narrative sophistication in fiction worldwide.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Viola Desmond",
                    ImagePath = "resources/viola-desmond.jpg",
                    Subtitle ="Trailblazer of Civil Rights",
                    ActiveEra ="1940s-1960s CE",
                    PrimaryLocation="New Glasgow, Nova Scotia",
                    InfoBlurb="Viola Desmond was a trailblazing Canadian businesswoman whose refusal to leave a whites-only section of a Nova Scotia movie theater in 1946 became a landmark moment in the fight against racial segregation. Her courage and dignity in the face of discrimination helped spark awareness and activism around civil rights in Canada, decades before similar movements gained momentum worldwide. Beyond that singular act, Desmond ran a successful beauty salon and school, breaking barriers for Black women in business and society. Today, she is celebrated as a symbol of resilience and justice, inspiring generations to stand against inequality.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Gráinne Ní Mháille",
                    ImagePath = "resources/grainne.jpg",
                    Subtitle ="The Pirate Queen of Ireland",
                    ActiveEra ="Mid-to-late 16th Century CE",
                    PrimaryLocation="County Mayo, Ireland",
                    InfoBlurb="As the chief of her clan, Gráinne Ní Mháille carved a place in history through mastery of the seas, fearless leadership, and unwavering defiance of English rule. Her reputation as a cunning navigator and audacious strategist extended across Ireland and beyond. She famously met with Queen Elizabeth I to advocate for the protection of her lands, demonstrating her boldness and political acumen in the face of great power. Gráinne’s story resonates through the centuries as a celebration of maritime skill, resilience, and the strength of women in leadership, making her a timeless symbol of Irish independence.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Marsha P. Johnson",
                    ImagePath = "resources/marsha.jpg",
                    Subtitle ="The Spark of Stonewall",
                    ActiveEra ="1960s-1990s CE",
                    PrimaryLocation="New York City, New York",
                    InfoBlurb="Marsha P. Johnson, affectionately known as Saint Marsha, was a fearless trans woman and LGBTQ+ activist whose life was dedicated to justice, visibility, and community. She played a pivotal role in the Stonewall uprising, standing on the frontlines of the gay rights movement and advocating tirelessly for those often overlooked. As a co-founder of the Street Transvestite Action Revolutionaries (STAR), she provided shelter, support, and a voice for transgender people and other marginalized members of society. Known for her unwavering spirit and her signature phrase, “Pay it No Mind,” Marsha’s courage and compassion made her a beacon of hope and resilience whose legacy continues to inspire activists worldwide.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Jane Goodall",
                    ImagePath = "resources/jane-goodall.jpg",
                    Subtitle ="The Woman who Spoke with Apes",
                    ActiveEra ="1960s-2020s CE",
                    PrimaryLocation="Gombe, Tanzania",
                    InfoBlurb="Jane Goodall’s pioneering studies of chimpanzees revolutionized the scientific understanding of animal behavior and reshaped humanity’s view of our closest relatives. Beginning her research in Gombe Stream National Park with remarkable patience and empathy, she observed complex social structures, tool use, and emotional depth among chimpanzees—insights that challenged long-held assumptions about the human-animal divide. Beyond her groundbreaking fieldwork, Jane has been a tireless advocate for conservation, animal welfare, and environmental stewardship for decades, inspiring generations to act with compassion toward all living beings. Her passing in 2025 marks the end of a remarkable life, but her legacy of curiosity, care, and dedication continues to shape science and activism worldwide.",
                    wikiURL=""
                },
                new CarouselItem
                {
                    Title = "Eleanor of Aquitaine",
                    ImagePath = "resources/queen-eleanor.JPG",
                    Subtitle ="The Lioness of Two Thrones",
                    ActiveEra ="12th Century CE",
                    PrimaryLocation="England and France",
                    InfoBlurb="As queen of both France and England, Eleanor of Aquitaine wielded extraordinary influence over medieval politics, culture, and the arts. Known for her intelligence and ambition, she boldly supported her sons’ rebellions against King Henry II, a move that led to fifteen years of house arrest but never diminished her authority. Eleanor’s innovations, such as introducing built-in fireplaces, reflected her practical ingenuity, and she remarkably lived to her 80s, leaving a lasting imprint on European history. Her life exemplifies resilience, power, and the enduring legacy of a woman ahead of her time.",
                    wikiURL=""
                }
            };
            this.DataContext = this;
            UpdateVisiblePortraits();
        }

        private void Carousel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Carousel.SelectedItem is CarouselItem item)
            {
                // Navigate to page details
                MessageBox.Show($"{item.InfoBlurb}");
            }
        }

        private void UpdateVisiblePortraits()
        {
            VisiblePortraits.Clear();

            int half = VisibleCount / 2;
            int total = Portraits.Count;

            for (int offset = -half; offset <= half; offset++)
            {
                int index = (_currentCenterIndex + offset+ total) % total;
                VisiblePortraits.Add(Portraits[index]);
            }
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            _currentCenterIndex--;

            if (_currentCenterIndex < 0)
            {
                _currentCenterIndex = Portraits.Count - 1;
            }
            UpdateVisiblePortraits();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            _currentCenterIndex++;

            if (_currentCenterIndex >= Portraits.Count )
            {
                _currentCenterIndex = 0;
            }
            UpdateVisiblePortraits();
        }
    }
}