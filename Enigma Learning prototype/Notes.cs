using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Learning_prototype
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();

        }

        public static int realSubjectNo;
        public static int cellsSlideNo;
        public static int organisationSlideNo;
        public static int chemicalMeasureSlideNo;
        public static int chemicalChangeSlideNo;
        public static int wavesSlideNo;

        private void btn_Back_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Do you really want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                this.Close();
                RevisionStyle revisionStyle = new RevisionStyle();
                revisionStyle.Show();
            }
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            switch (realSubjectNo)
            {
                case 1:
                    this.Text = "Cells";
                    this.BackgroundImage = Enigma_Learning.Properties.Resources.cells_themed_image;
                    heading1.Text = "CELLS";
                    Biology_Cells_1();
                    break;
                case 2:
                    this.Text = "Organisation";
                    this.BackgroundImage = Enigma_Learning.Properties.Resources.organisation_theme;
                    heading1.Text = "ORGANISATION";
                    Biology_Organisation_1();
                    break;
                case 11:
                    this.Text = "Chemical Measurements";
                    this.BackgroundImage = Enigma_Learning.Properties.Resources.chemical_measurements;
                    heading1.Text = "CHEMICAL MEASUREMENTS";
                    Chemical_Measurements_1();
                    break;
                case 12:
                    this.Text = "Chemical Changes";
                    this.BackgroundImage = Enigma_Learning.Properties.Resources.chemical_changes_theme;
                    heading1.Text = "CHEMICAL CHANGES";
                    Chemistry_ChemicalChange_1();
                    break;
                case 21:
                    this.Text = "Waves";
                    this.BackgroundImage = Enigma_Learning.Properties.Resources.soundwaves_for_physics;
                    heading1.Text = "WAVES";
                    Physics_Waves_1();
                    break;
            }
        }

        //biology topics
        private void Biology_Cells_1()
        {
            cellsSlideNo = 1;
            text1.Location = new Point(68, 85);
            text1.Text = "•     All organisms are made of cells.\n" +
                "•      They can either be prokaryotic or eukaryotic.\n" +
                "•      Prokaryotes are organisms made of prokaryotic cells. They are simpler, smaller and basic, e.g bacteria.\n" +
                "•      Eukaryotes are organisms made of eukaryotic cells. They are bigger and more complex. Examples include, plant cells and animal cells.";
            subheading1.Location = new Point(68, 200);
            subheading1.Text = "Animal Cells";
            text2.Location = new Point(68, 235);
            text2.Text = "Animal cells have subcellular structures. These are the different parts of the cell:\n\n" +
                "•      Nucleus: controls the cell activities and stores genetic material (DNA).\n" +
                "•      Mitochondria: the site of aerobic respiration. Releases energy that the cell needs to work.\n" +
                "•      Cytoplasm: gel-like substance where chemical reactions take place.\n" +
                "•      Cell membrane: controls what goes in and out of the cell.\n" +
                "•      Ribosomes: where protein synthesis happens.";
            pictureBox1.Image = Enigma_Learning.Properties.Resources.cell_animal1;
            pictureBox1.Location = new Point(500, 380);
            pictureBox1.Visible = true;
            pictureBox1.Size = new Size(350, 250);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            btn_Previous.Enabled = false;
        }
        private void Biology_Cells_2()
        {
            cellsSlideNo = 2;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Plant Cells";
            text1.Location = new Point(68, 120);
            text1.Text = "Plant cells have a similar structure to animal cells. However, they have a few extra subcellular structures, such as:\n\n" +
                "•      Cell wall – supports the cell and strengthens it. It is made of cellulose.\n" +
                "•      Permanent vacuole – contains cell sap which is a weak solution of sugar and salt.\n" +
                "•      Chloroplasts – site of photosynthesis.Contains chlorophyll which absorbs light for photosynthesis.";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.Plant_Cell_min_1;
            pictureBox1.Location = new Point(68, 250);
            pictureBox1.Size = new Size(350, 250);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_3()
        {
            cellsSlideNo = 3;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Bacterial Cells";
            text1.Location = new Point(68, 120);
            text1.Text = "Bacteria is made of prokaryotic cells. It has a few subcellular structures, including:\n" +
                "•      Cell membrane\n" +
                "•      Cell wall\n" +
                "•      Cytoplasm\n" +
                "•      Plasmids – rings of DNA\n" +
                "•      Circular strand of DNA\n" +
                "•      No nucleus\n" +
                "•      No chloroplasts or mitochondria";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.Bacteria_Cell_pic;
            pictureBox1.Location = new Point(68, 330);
            pictureBox1.Size = new Size(375, 201);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_4()
        {
            cellsSlideNo = 4;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "MICROSCOPY";
            text1.Location = new Point(68, 120);
            text1.Text = "•     Microscopes are used to see things that are too small for us to see with our eyes.\n" +
                "•      There are two types of microscopes, light and electron microscopes.\n" +
                "•      There are two types of microscopes, light and electron microscopes.\n" +
                "•      Light microscopes use light to form and magnify images of specimen. They have a much lower magnification\n" +
                "       and resolution than electron microscopes.\n" +
                "•      Electron microscopes use electrons to form an image of a specimen. They have a higher magnification and\n" +
                "       resolution than light microscopes.\n" +
                "•      Electron microscopes let us see much smaller things such as mitochondria and chloroplasts in detail. Even\n" +
                "       ribosomes and plasmids.\n" +
                "                                           MAGNIFICATION = IMAGE SIZE / REAL SIZE";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "Preparing a slide using onion cells";
            subheading2.Location = new Point(68, 360);
            text2.Text = "•     Add a drop of water to the middle of the slide.\n" +
                "•      Separate an onion into layers and use a tweezer to peel off epidermal tissues from the\n" +
                "       bottom of a layer.\n" +
                "•      Place the tissue into the water.\n" +
                "•      Add a drop of stain which could be iodine solution. Stains add colour to\n" +
                "       objects in a cell.\n" +
                "•      Place a cover slip on top. Tilt it carefully and lower it to cover the specimen.\n" +
                "       Prevent any air bubbles.";
            text2.Location = new Point(68, 390);
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_5()
        {
            cellsSlideNo = 5;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "CELL DIFFERENTIATION";
            text1.Location = new Point(68, 120);
            text1.Text = "Differentiation is the process by which a cell changes to become specialised for its job.\n" +
                "•       Cells develop different subcellular structures and change into different cells.\n" +
                "•       This helps them carry out specific functions.\n" +
                "•       Cells in animals lose the ability to differentiate at an early stage, after becoming\n" +
                "        specialised whereas plant cells never lose this ability.\n" +
                "•       Differentiated cells are mainly used for repairing and replacing cells in mature animals.\n" +
                "•       Stem cells are undifferentiated cells.";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_6()
        {
            cellsSlideNo = 6;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "SPECIALISED CELLS";
            text1.Location = new Point(68, 120);
            text1.Text = "Sperm cells:\n" +
                "•      Sperm cell carries the male DNA to the female DNA.\n" +
                "•      It has a streamlined head and a tail that help it swim to the egg.\n" +
                "•      It contains lots of mitochondria to provide the energy needed to swim.\n" +
                "•      It also contains enzymes that digest through the egg cell membrane.\n\n\n\n" +
                "Nerve cells:\n" +
                "•      Nerve cells carry electrical impulses from one part of the body to\n" +
                "       another.\n" +
                "•      They are very long which helps them cover more distance.\n" +
                "•      They also have branched connections at their ends which form\n" +
                "       branched connections throughout the body by connecting to other\n" +
                "       nerve cells.";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.sperm_cell;
            pictureBox1.Location = new Point(700, 120);
            pictureBox1.Size = new Size(501, 299);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_7()
        {
            cellsSlideNo = 7;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "SPECIALISED CELLS";
            text1.Location = new Point(68, 120);
            text1.Text = "Muscle cells:\n" +
                "•      These cells contract.\n" +
                "•      They are very long so they have enough space to contract.\n" +
                "•      They also have lots of mitochondria to provide the energy needed for contraction.\n\n" +
                "Root hair cells:\n" +
                "•      These are cells grow into long hairs on the surface of plant roots.\n" +
                "•      It provides the plant a big surface area for absorbing water and mineral ions from the soil.";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.root_cell;
            pictureBox1.Size = new Size(428, 213);
            pictureBox1.Location = new Point(68, 350);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_8()
        {
            cellsSlideNo = 8;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "SPECIALISED CELLS";
            text1.Location = new Point(68, 120);
            text1.Text = "Phloem and Xylem cells:\n" +
                "•      Phloem cells form phloem tubes whereas xylem cells form xylem tubes.\n" +
                "•      These transport substances like food and water around the plants.\n" +
                "•      The cells are joined by long cells joined end to end.\n" +
                "•      Phloem cells have very few subcellular structures and xylem cells are hollow in the centre.\n" +
                "•      This is to allow stuff to flow through them.";
            subheading2.Text = "CHROMOSOMES AND MITOSIS";
            subheading2.Location = new Point(68, 280);
            text2.Text = "•     A nucleus contains genetic material.\n" +
                "•      This genetic material is in the form of chromosomes.\n" +
                "•      Chromosomes are coiled up lengths of DNA.\n" +
                "•      Each chromosome contains a large number of genes.\n" +
                "•      Different characteristics are controlled by different genes.\n" +
                "•      Chromosomes go around in pairs – one from the organism’s mother and one from the father.\n" +
                "•      There are 23 pairs of chromosomes in a human cell.";
            text2.Location = new Point(68, 310);
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_9()
        {
            cellsSlideNo = 9;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "THE CELL CYCLE";
            text1.Location = new Point(68, 120);
            text1.Text = "In multicellular organisms, cells divide to produce new cells.\n" +
                "This is part of the cell cycle.\n" +
                "The stage of the cell cycle when cells divide is called mitosis.\n" +
                "Mitosis is used by cells for growth and to replace damaged cells.\n" +
                "These cells have the same number of chromosomes.\n" +
                "There are two main stages of the cell cycle:";
            subheading2.Text = "Growth and Repair Replication";
            subheading2.Location = new Point(68, 280);
            text2.Text = "•     In a cell that is not dividing the DNA is spread out in long strings.\n" +
                "•      The cell grows and replicates its subcellular structures such as mitochondria\n" +
                "       and ribosomes before dividing.\n" +
                "•      After this, the cell duplicates its DNA.";
            text2.Location = new Point(68, 310);
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_10()
        {
            cellsSlideNo = 10;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Mitosis";
            text1.Location = new Point(68, 120);
            text1.Text = "•     The chromosomes line up at the centre of the cell and cell fibres pull them apart.\n" +
                "       The two arms of each chromosome are pulled to opposite ends of the cell.\n" +
                "•      Membranes form around each of the chromosomes.\n" +
                "•      This forms the nucleus of the cells.\n" +
                "•      The cytoplasm and cell membrane divide to form two new identical daughter cells.\n" +
                "•      Their DNA is identical to the parent cell.";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.mitosis;
            pictureBox1.Location = new Point(68, 270);
            pictureBox1.Size = new Size(480, 306);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_11()
        {
            cellsSlideNo = 11;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Binary Fission";
            text1.Location = new Point(68, 120);
            text1.Text = "•     Binary fission is cell division in bacterial cells.\n" +
                "•      The circular DNA and plasmids replicate.\n" +
                "•      The cell gets bigger.\n" +
                "•      The circular DNA strands move to opposite poles of the cell.\n" +
                "•      The cytoplasm divides and new walls form.\n" +
                "•      Two new daughter cells are produced and each of them has one copy of the\n" +
                "       circular DNA but different numbers of plasmids.\n" +
                "•      Bacteria divides quickly under the right conditions e.g warm environment and\n" +
                "       enough nutrients.\n" +
                "•      If conditions are not suitable, they stop dividing and begin to die.\n\n\n" +
                "Mean division time: the average amount of time it takes for one bacterial cell to divide into two.";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.binary_fission;
            pictureBox1.Location = new Point(780, 20);
            pictureBox1.Size = new Size(281, 343);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_12()
        {
            cellsSlideNo = 12;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "STEM CELLS";
            text1.Location = new Point(68, 120);
            text1.Text = "The process by which cells change to become specialised for its job is called differentiation.\n" +
                "•      Stem cells are undifferentiated cells and can divide to produce many more undifferentiated cells.\n" +
                "•      Stem cells can differentiate in different types of cells.\n" +
                "•      Stem cells are found in early human embryos.\n" +
                "•      Adult stem cells however are only found in certain places like bone marrow.\n" +
                "•      Adult cells cannot turn into any type of cell, only a few like blood cells.\n" +
                "•      Stem cells can be grown in labs to produce clones and made to differentiate into specialised cells\n" +
                "       to use in medicine and research.\n\n" +
                "Medicine uses adult stem cells transferred from the bone marrow of a healthy person to cure diseases.\n" +
                "•      They can be used to replace faulty cells in sick people.\n" +
                "•      They can be used to make insulin-producing cells for people with diabetes.\n" +
                "•      They can also be used to make nerve cells for people paralysed by spinal injury.\n" +
                "•      Stems cells are used for therapeutic cloning- an embryo could be made to have the same genetic\n" +
                "       information as the patient. This means that the stem cells produced wouldn’t be rejected by the\n" +
                "       patient’s body if used to replace faulty cells.";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_13()
        {
            cellsSlideNo = 13;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "STEM CELLS";
            text1.Location = new Point(68, 120);
            text1.Text = "•     However, stem cells grown in labs could be contaminated with a virus which could be passed on to the\n" +
                "       patient making them sicker.\n" +
                "•      Some people are against stem cell research as they believe human embryos shouldn’t be used for research.\n" +
                "•      Some think existing people suffering are more important than the rights of embryos.\n" +
                "•      Embryos used in research are usually unwanted ones from fertility clinics and if they weren’t used for research\n" +
                "       would be destroyed.\n" +
                "•      Campaigners feel that scientists should find other sources of stem cells.\n" +
                "•      Stem cell research is banned in some countries but is allowed in the UK with strict guidelines.";
            subheading2.Text = "Stem cells in plants";
            subheading2.Location = new Point(68, 320);
            text2.Text = "•     Stem cells are found in the meristem of a plant- this is where growth occurs.\n" +
                "•      Cells in the meristem tissues can differentiate into any type of plant cell.\n" +
                "•      Stems cells can also be used to produce clones of a whole plant quickly and cheaply.\n" +
                "•      They can also be used to grow more plants of rare species to prevent them from wiping them out.\n" +
                "•      They are used to grow identical crops that have a desired feature for farmers, e.g disease resistance.";
            text2.Location = new Point(68, 350);
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_14()
        {
            cellsSlideNo = 14;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "DIFFUSION";
            text1.Location = new Point(68, 120);
            text1.Text = "Diffusion is the spreading out of particles from an area of higher concentration to an area of lower concentration.\n\n" +
                "Diffusion happens in both solutions and gasses as the particles are free to move about.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.diffusion;
            pictureBox1.Size = new Size(229, 328);
            pictureBox1.Location = new Point(68, 200);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_15()
        {
            cellsSlideNo = 15;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Factors affecting the rate of diffusion:";
            text1.Location = new Point(68, 120);
            text1.Text = "•     The greater the concentration gradient, the faster the rate of diffusion.\n" +
                "•      The higher the temperature, the faster the rate of diffusion.\n" +
                "•      The larger the surface area of a membrane, the faster the rate of diffusion.\n\n" +
                "Diffusion is a passive process because it does not require an energy. The cell membrane holds the\n" +
                "cell together and controls what goes in and out of cells by diffusion. Only small molecules can diffuse\n" +
                "through the cell membrane through the pores. E.g oxygen, glucose, amino acids, and water. Big molecules\n" +
                "such as proteins cannot fit through the membrane.";
            subheading2.Text = "OSMOSIS";
            subheading2.Location = new Point(68, 320);
            text2.Text = "Osmosis is the movement of water molecules across a partially permeable membrane from a region\n" +
                "of higher water concentration to a region of lower water concentration.";
            text2.Location = new Point(68, 350);
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(150, 410);
            pictureBox1.Image = Enigma_Learning.Properties.Resources.osmosis;
            pictureBox1.Size = new Size(324, 198);
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_16()
        {
            cellsSlideNo = 16;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "OSMOSIS";
            text1.Location = new Point(68, 120);
            text1.Text = "•     A partially permeable membrane is one with very small holes in it, so that only small particles\n" +
                "       like water can fit through it.\n" +
                "•      Water particles move from the area where there is a higher concentration of water molecules to an area with\n" +
                "       lower water molecule concentration.\n" +
                "•      Osmosis is a passive process – it does not require energy.";
            subheading2.Text = "ACTIVE TRANSPORT";
            subheading2.Location = new Point(68, 240);
            text2.Text = "The movement of particle from an area of lower concentration to an area of higher concentration – against the\n" +
                "concentration gradient. This process requires energy.\n" +
                "•      Plant roots are covered in millions of root hair cells that stick out into the soil.\n" +
                "•      Root hair cells give the plant a large surface area for absorption of water and mineral substances from the soil.\n" +
                "•      The concentration of minerals is higher in the root hair cells than in the soil.\n" +
                "•      Active transport also happens in humans, for example in taking glucose from the gut and from the kidney tubules.";
            text2.Location = new Point(68, 270);
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(68, 420);
            pictureBox1.Image = Enigma_Learning.Properties.Resources.active_transport;
            pictureBox1.Size = new Size(342, 159);
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_17()
        {
            cellsSlideNo = 17;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Active transport in the gut:";
            text1.Location = new Point(68, 120);
            text1.Text = "•     There is a higher concentration of amino acids in the gut, so they diffuse naturally into the blood.\n" +
                "•      However, there can be a lower concentration of nutrients in the gut than there is in the blood.\n" +
                "•      In this case, the molecules will have to move against the concentration gradient.\n" +
                "•      Active transport allows nutrients to be taken into the blood, even though the concentration\n" +
                "       gradient is the wrong way.";
            subheading2.Text = "EXCHANGE SURFACES";
            subheading2.Location = new Point(68, 240);
            text2.Text = "Cells use diffusion to take in the substances they need and to get rid of waste substances. For example,\n" +
                "oxygen and carbon are transferred between cells and the environment during gas exchange. The rate exchange\n" +
                "of substances in an organism depends on the surface area to volume ratio. In single-celled organisms, it is\n" +
                "easy for gasses and dissolved substances to diffuse directly into or out of the cell across the membrane.\n" +
                "Multicellular organisms have a smaller surface area compared to their volume. Therefore, not enough substances\n" +
                "can diffuse from their outside surface to supply their entire volume.\n\n" +
                "Factors that maximise the effectiveness of exchange surfaces:\n" +
                "•      Thin membrane – short distance to diffuse.\n" +
                "•      Large surface area – lots of substances can diffuse at the same time\n" +
                "•      Lots of blood vessels – get substances into and out of the blood quickly.\n" +
                "•      In animals, gas exchange surfaces are ventilated to allow air to move in and out.";
            text2.Location = new Point(68, 270);
            pictureBox1.Visible = false;
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_18()
        {
            cellsSlideNo = 18;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "EXCHANGING SUBSTANCES";
            text1.Location = new Point(68, 120);
            text1.Text = "Gas exchange in lungs\n" +
                "•      The lungs are specialised to transfer oxygen to the blood\n" +
                "       and to remove carbon dioxide from it.\n" +
                "•      It contains millions of air sacs called alveoli.\n" +
                "•      This is where gas exchange happens.\n\n" +
                "The alveoli have:\n" +
                "•      A large surface area\n" +
                "•      A moist lining for dissolving gases\n" +
                "•      Very thin walls\n" +
                "•      A good blood supply.\n\n" +
                "Inside the small intestine, there are millions of hair-like structures called villi.\n" +
                "•      They increase the surface area of the small intestine so that food is absorbed more easily.\n" +
                "•      They have a single layer of surface cells\n" +
                "•      They also have a good blood supply.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.lung;
            pictureBox1.Location = new Point(650, 120);
            pictureBox1.Size = new Size(254, 263);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Cells_19()
        {
            cellsSlideNo = 19;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "STRUCTURE OF LEAVES";
            text1.Location = new Point(68, 120);
            text1.Text = "•     Carbon dioxide diffuses into the cells through the air spaces within the leaf.\n" +
                "•      This is where photosynthesis happens.\n" +
                "•      There is an exchange surface underneath the leaf. This is covered in small holes called stomata.\n" +
                "•      The stomata allow carbon dioxide, oxygen and water to diffuse through it.\n" +
                "•      The size of the stomata is controlled by guard cells.\n" +
                "•      Guard cells close the stomata if the plant is losing water faster than it is being replaced by the roots.\n" +
                "•      Without the guard cells the plant would wilt.\n" +
                "•      The area of this exchange surface is increased by the flattened shape of the leaf.\n" +
                "•      The walls of the cells inside of the leaf is made of air spaces to increase the area of this surface.\n" +
                "•      This means there is more chance for carbon dioxide to get into the cells.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.leaf;
            pictureBox1.Location = new Point(68, 370);
            pictureBox1.Size = new Size(312, 208);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Biology_Organisation_1()
        {
            btn_Previous.Enabled = false;
            organisationSlideNo = 1;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic63;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(634, 519);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Biology_Organisation_2()
        {
            btn_Previous.Enabled = true;
            organisationSlideNo = 2;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic64;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(691, 520);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Biology_Organisation_3()
        {
            organisationSlideNo = 3;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic65;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(613, 519);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Biology_Organisation_4()
        {
            btn_NextSlide.Enabled = true;
            organisationSlideNo = 4;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic66;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(670, 520);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Biology_Organisation_5()
        {
            btn_NextSlide.Enabled = false;
            organisationSlideNo = 5;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic67;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(583, 520);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        //chemistry topics
        private void Chemical_Measurements_1()
        {
            btn_Previous.Enabled = false;
            chemicalMeasureSlideNo = 1;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic55;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(606, 512);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_2()
        {
            btn_Previous.Enabled = true;
            chemicalMeasureSlideNo = 2;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic56;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(624,454);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_3()
        {
            chemicalMeasureSlideNo = 3;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic57;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(583,520);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_4()
        {
            chemicalMeasureSlideNo = 4;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic58;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(647,466);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_5()
        {
            chemicalMeasureSlideNo = 5;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic59;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(671,450);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_6()
        {
            chemicalMeasureSlideNo = 6;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic60;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(662,433);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_7()
        {
            btn_NextSlide.Enabled = true;
            chemicalMeasureSlideNo = 7;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic61;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(663,416);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemical_Measurements_8()
        {
            btn_NextSlide.Enabled = false;
            chemicalMeasureSlideNo = 8;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic62;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(657,515);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_1()
        {
            btn_Previous.Enabled = false;
            chemicalChangeSlideNo = 1;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Acids and Alkalis";
            text1.Location = new Point(68, 120);
            text1.Text = "•     Acids and alkalis are measured on how acidic (or alkaline) they are on a pH scale.\n" +
                "•      pH stands for Power of Hydrogen\n" +
                "•      The lower the pH the more acidic it is and the higher the pH the more alkaline it is\n" +
                "•      Pure water and any other neutral substances have a pH of 7\n" +
                "•      Lower pH means more hydrogen ions are present while higher pH means more hydroxide ions are present ";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.ph_meter;
            pictureBox1.Location = new Point(68, 250);
            pictureBox1.Size = new Size(508, 297);
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = false;
        }
        private void Chemistry_ChemicalChange_2()
        {
            btn_Previous.Enabled = true;
            chemicalChangeSlideNo = 2;
            subheading1.Text = "Measuring the pH of a substance:";
            subheading1.Location = new Point(68, 85);
            text1.Text = "•     Qualitative methods:\n" +
                "       You can use indicators which change the colour of a solution depending on the amount of hydrogen\n" +
                "       or hydroxide ions are present e.g. a universal indicator shows a wide range of colours as shown by\n" +
                "       the picture above whereas indicators such as phenolphthalein only have two (colourless and pink). This\n" +
                "       method means its more descriptive and so more subjective – some people may disagree to what colour you\n" +
                "       think it is. Therefore this method isn’t as accurate.\n\n" +
                "       Quantitative methods:\n" +
                "       This involves using a pH probe and pH meter. The probe is placed inside the solution you want to know the\n" +
                "       pH of and it’ll display the value numerically. This method is more accurate as it isn’t subjective\n" +
                "       (unlike using an indicator).";
            text1.Location = new Point(68, 120);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_3()
        {
            chemicalChangeSlideNo = 3;
            subheading1.Text = "Neutralisation of acids:";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Base – insoluble substance with pH greater than 7 (e.g. insoluble metal hydroxides and metal oxides)\n" +
                "Alkali – substance which has a pH greater than 7 AND is soluble (e.g. soluble metal hydroxides)\n" +
                "The product of reacting an acid with a base is called neutralisation. Acids are neutralised to form water and a salt.\n" +
                "The salt produced in the reaction depends on:\n" +
                "•      The acid used – hydrochloric acid results in chlorides, nitric acid results in nitrates and sulfuric acid results in sulfates.\n" +
                "•      The positive ions in the alkali or base.\n\n\n\n\n" +
                "The (aq) and (l) are state symbols used to describe what state each reactant or product is in. (aq) represents aqueous which means\n" +
                "it is dissolved in solution.\n" +
                "(l) is a liquid\n" +
                "(s) is a solid\n" +
                "And (g) is a gas";
            text1.Location = new Point(68, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic13;
            pictureBox1.Size = new Size(372, 74);
            pictureBox1.Location = new Point(68, 270);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_4()
        {
            chemicalChangeSlideNo = 4;
            subheading1.Text = "Strong & Weak Acids";
            subheading1.Location = new Point(68, 85);
            text1.Text = "";
            text1.Location = new Point(68, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic14;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(459, 326);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic15;
            pictureBox2.Location = new Point(68, 450);
            pictureBox2.Size = new Size(448, 131);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_5()
        {
            chemicalChangeSlideNo = 5;
            subheading1.Text = "Titrations";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Titrations are used to find out the concentration of either acid or alkali while knowing their volume. The method\n" +
                "includes a neutralisation of either acid or alkali and measuring how much of the other substance was needed to neutralise it.\n" +
                "Some suggested indicators for this practical:\n" +
                "•      Phenolphthalein which is pink as an alkali and colourless as an acid.\n" +
                "•      Methyl Orange which is red in acids and yellow in alkalis.\n" +
                "•      Universal indicator which is red when acidic and blue when alkaline.\n\n" +
                "Method of experiment:\n" +
                "1.     To find the concentration of an alkali (e.g. sodium hydroxide), use a pipette and pipette filler to place 25cm3 of NaOH\n" +
                "       into a conical flask.\n" +
                "2.     Add 3-5 drops of indicator (phenolphthalein) and swirl gently.\n" +
                "3.     Set up a burette on a stand and close the tap. Add acid of known concentration into the burette up until you reach the 0 line.\n" +
                "       Make sure the meniscus is sitting on the 0 line\n\n" +
                "Meniscus – the curve of the upper surface of a liquid caused by surface tension (picture on next slide)\n\n" +
                "4.     Complete a rough titre first. Do this by opening the tap and letting the acid fall into the alkali. Make\n" +
                "       sure to swirl while it drops in. Then as the solution starts to turn colourless, close the tap and read\n" +
                "       the final volume of the leftover acid in the burette. This rough titre gives you a rough idea of where\n" +
                "       the end point of the neutralisation is.";
            text1.Location = new Point(68, 120);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_6()
        {
            chemicalChangeSlideNo = 6;
            subheading1.Text = "Titrations";
            subheading1.Location = new Point(68, 85);
            text1.Text = "(picture: the line shows the meniscus reading to be taken)\n" +
                "5.     Now do more accurate readings, and when you get within 10cm3 of the end point\n" +
                "       of the rough titre, open the tap slightly to let in the acid drop by drop. Keep\n" +
                "       swirling it as you do so.\n" +
                "6.     Do this several times until you get concordant results.\n\n" +
                "Concordant – results within 0.1cm3 of each other (aka consistent readings)\n\n" +
                "7.     Now using your results calculate the mean of them. This is the volume of acid\n" +
                "       needed to neutralise the alkali.\n" +
                "You can calculate the concentration of the alkali now using the equation\n\n" +
                "Concentration = number of moles / mean volume\n" +
                "(This will be covered more on the\n" +
                "topic of calculations)";
            text1.Location = new Point(470, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic16;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(400,400);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_7()
        {
            chemicalChangeSlideNo = 7;
            subheading1.Text = "The Reactivity Series";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Reactivity is determined by many things. In metals its determined by their tendency to form\n" +
                "positive ions (how easily they lose electrons). This means group 1 metals are a lot more reactive\n" +
                "than transition metals due to only having 1 electron in their outer shell. When the metals react\n" +
                "with either water or an acid (in solution) they lose outer electrons and therefore form positive\n" +
                "ions. The metals higher in the reactivity series react more easily in solutions.\n\n" +
                "To investigate the reactivity of metals when reacting with acids:\n" +
                "There are many ways to find out which metal is more reactive. With higher reactivity comes faster\n" +
                "rate of reaction, and some signs of a fast reaction are:\n" +
                "•      Rate at which hydrogen bubbles are given off\n" +
                "•      The change in temperature of the solution. The higher the change the more reactive a metal is\n" +
                "•      The rate at which the reactant is used up (the metal)\n" +
                "When this reaction of metal and acid takes place, salt and hydrogen gas is produced.";
            text1.Location = new Point(420, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic17;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(350, 371);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic18;
            pictureBox2.Location = new Point(420, 440);
            pictureBox2.Size = new Size(328, 77);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_8()
        {
            chemicalChangeSlideNo = 8;
            subheading1.Text = "The Reactivity Series";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Soluble salts can be made from acids. This is done by reacting them with insoluble\n" +
                "substances which are solids e.g. metals, metal hydroxides, metal carbonates or metal\n" +
                "oxides. This is done by:\n" +
                "1.     Heat the acid with a Bunsen burner.\n" +
                "2.     Then add the insoluble base until no more reacts.\n" +
                "3.     Filer off excess solid.\n\n" +
                "To get a dry sample of the soluble salt you can use a Bunsen burner or electric heater\n" +
                "in order to crystallise the solution. The water will evaporate leaving crystals of the\n" +
                "salt which can then be filtered out once again and dried.";
            text1.Location = new Point(530, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic19;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(460, 414);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_9()
        {
            chemicalChangeSlideNo = 9;
            subheading1.Text = "Extraction of metals and reduction";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Unreactive metals can be found in the earth and not need further processes to extract e.g. Gold. However, others\n" +
                "require chemical reactions to extract them. To separate them we use a method called reduction. This reaction separates \n" +
                "the metal from the ore.\n\n" +
                "Reduction is the LOSS of oxygen. This is used to remove the metal from the ore.\n" +
                "Oxidation is the GAIN of oxygen. This is how the metal gained the oxygen forming the oxide (ore) from which it needs\nto be extracted.\n" +
                "How metals are extracted depending on their reactivity. Some metals like Zinc Iron and Copper can be extracted using\n" +
                "carbon. This reaction includes the metal oxide to react with carbon to produce a pure metal and carbon through the\n" +
                "gain of oxygen, to form carbon dioxide. For example, lead(II) oxide and carbon gives lead and carbon dioxide. But\n" +
                "this method is only used for metals which are less reactive than carbon.";
            text1.Location = new Point(68, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic20;
            pictureBox1.Location = new Point(68, 390);
            pictureBox1.Size = new Size(350, 196);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_10()
        {
            chemicalChangeSlideNo = 10;
            subheading1.Text = "Extraction of metals and reduction";
            subheading1.Location = new Point(68, 85);
            text1.Text = "For metals more reactive than Carbon, they have to be extracted via electrolysis. This is because carbon can only\n" +
                "take oxygen away if the metals are less reactive than carbon. However, electrolysis is an expensive method due to\n" +
                "the amount of energy exerted using electricity.\n\n\n" +
                "Oxidation and Reduction doesn’t just apply to the gain or loss of oxygen. It also applied to the loss or gain of electrons.\n" +
                "Oxidation\nIs\nLoss of electrons\nReduction\nIs\nGain\n" +
                "A redox reaction is one that contains both reactions - RED(uction)OX(idation)\n" +
                "An example of a redox reaction is a displacement reaction\n" +
                "The main rule of displacement reactions is that a more reactive metal will displace a less reactive one\n" +
                "from its compound. This is a useful method when you want only a specific metal in a compound.";
            text1.Location = new Point(68, 120);
            subheading2.Text = "Redox Reactions";
            subheading2.BringToFront();
            subheading2.Location = new Point(68, 210);
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_11()
        {
            chemicalChangeSlideNo = 11;
            subheading1.Text = "Redox Reactions";
            subheading1.Location = new Point(68, 85);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic21;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(373, 114);
            text1.Text = "In this reaction, the carbon is more reactive than the iron therefore it displaces it and so the carbon gains oxygen and\n" +
                "iron loses them. Iron gains electrons while carbon loses them, as iron becomes a pure metal and carbon is now\n" +
                "a compound.\n" +
                "The metal ions gain electrons(reduction) and metal atoms lose them(oxidation).";
            text1.Location = new Point(68, 240);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic22;
            pictureBox2.Location = new Point(68, 350);
            pictureBox2.Size = new Size(462, 194);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_12()
        {
            chemicalChangeSlideNo = 12;
            subheading1.Text = "Electrolysis";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Electrolysis is the process of splitting up ionic compounds using electricity.\n" +
                "An electrolyte is a molten or dissolved ionic compound.\n" +
                "Process of electrolysis:\n" +
                "•      An electric current is passed through the electrolyte and the ions split and move towards their opposing\n" +
                "       electrodes - positive ions(cations) move towards negative electrode(cathode) and the negative ions(anions)\n" +
                "       move towards the positive electrode(anode).\n" +
                "•      The electrolyte has to be molten or dissolved as the ions only carry charge when they are free to move. When\n" +
                "       they’re solid no electricity can pass through.\n" +
                "•      When the ions lose or gain electrons they are discharged from the electrolyte and form uncharged elements.\n" +
                "•      When the cations get to the cathode they are reduced.\n" +
                "•      When the anions get to the anode they are oxidised.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic23;
            pictureBox1.Location = new Point(68, 400);
            pictureBox1.Size = new Size(303, 85);
            text1.Location = new Point(68, 120);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_13()
        {
            chemicalChangeSlideNo = 13;
            subheading1.Text = "Electrolysis";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Electrolysis is used when a metal is more reactive than carbon. A lot of energy is used to melt the ore and\n" +
                "produce the electric current. An example of a metal extracted from ore is Aluminium. It is extracted from\n" +
                "bauxite via electrolysis. Bauxite doesn’t have pure aluminium metal but aluminium oxide. In order to save\n" +
                "as much energy – cryolite is used. It is an aluminium based compound which lowers aluminium’s already high\n" +
                "melting point. As the mixture starts to become molten, the ions become free and the aluminium ions are \n" +
                "attracted to the negative electrode whereas the oxygen ions are attracted to the positive electrode.\n" +
                "•      Aluminium gains 3 electrons becoming aluminium metal. This then sinks to the bottom of the tank\n" +
                "       and can be collected.\n" +
                "•      Each oxygen atom loses two electrons each, they combine and form oxygen gas.\n" +
                "There are 4 electrons needed because oxygen is a diatomic element and also forms 2- ions.The electrodes\n" +
                "are made of carbon. These need to be replaced regularly as the carbon reacts with the oxygen forming\n" +
                "carbon dioxide.";
            text1.Location = new Point(68, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic25;
            pictureBox1.Location = new Point(68, 420);
            pictureBox1.Size = new Size(486, 167);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_14()
        {
            chemicalChangeSlideNo = 14;
            subheading1.Text = "Electrolysis";
            subheading1.Location = new Point(68, 85);
            text1.Text = "Electrolysis of aqueous solutions:\n" +
                "•      In aqueous solutions there’s ions from the compound and also the water (H+ and OH- ions)\n" +
                "•      In order to know which ions are left in solution and which ones are produced at the cathode you will\n" +
                "       need to know which one is more reactive.\n" +
                "•      There are only two ions which can be produced at the cathode: the metal ion or the hydrogen ion. If the\n" +
                "       metal ion (which after forming a metal atom) is more reactive than hydrogen then hydrogen gas will be\n" +
                "       released. But if the metal is less reactive then a solid layer of metal will be produced around the\n" +
                "       electrode. Aka the less reactive one will be produced at the cathode while the more reactive one will\n" +
                "       stay in solution. For example if the ions Sodium and Hydrogen were in the mixture, hydrogen would be\n" +
                "       released because its less reactive, but if it was copper then a solid layer of copper would form and the\n" +
                "       hydrogen ions would stay in the mixture.\n" +
                "•      At the anode there will be only the negative ions produced, the hydroxide ion and another negative ion. If\n" +
                "       the negative ion happens to be a halide ion (group 7 – iodide, bromide, chloride) then molecules of either\n" +
                "       iodine, bromine or chlorine will be produced. If no halide ions are present then the hydroxide ions\n" +
                "       will be discharged releasing oxygen.";
            text1.Location = new Point(68, 120);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic26;
            pictureBox1.Location = new Point(68, 500);
            pictureBox1.Size = new Size(336, 88);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Chemistry_ChemicalChange_15()
        {
            chemicalChangeSlideNo = 14;
            subheading1.Text = "Electrolysis";
            subheading1.Location = new Point(68, 85);
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic27;
            pictureBox1.Location = new Point(68, 120);
            pictureBox1.Size = new Size(360, 307);
            text1.Text = "If asked how to identify the gases produced at the anode there are tests you can do to\n" +
                "identify. For example oxygen relights a glowing splint";
            text1.Location = new Point(430, 120);
            pictureBox2.Visible = true;
            pictureBox2.Image = Enigma_Learning.Properties.Resources.pic28;
            pictureBox2.Location = new Point(430, 180);
            pictureBox2.Size = new Size(668, 190);
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox3.Visible = false;
        }

        //physics topics
        private void Physics_Waves_1()
        {
            btn_Previous.Enabled = false;
            wavesSlideNo = 1;
            text1.Location = new Point(68, 85);
            text1.Text = "Waves are one of the ways in which energy may be transferred between stores. Waves can be described as oscillations, or\n" +
                "vibrations about a rest position. For example:\n" +
                "•      sound waves cause air particles to vibrate back and forth\n" +
                "•      ripples cause water particles to vibrate up and down\n" +
                "The direction of these oscillations is the difference between longitudinal or transverse waves. In longitudinal waves,\n" +
                "the vibrations are parallel to the direction of wave travel. In transverse waves, the vibrations are at right angles to\n" +
                "the direction of wave travel. Mechanical waves cause oscillations of particles in a solid, liquid or gas and must have a\n" +
                "medium to travel through. Electromagnetic waves cause oscillations in electrical and magnetic fields.\n" +
                "All waves transfer energy, but they do not transfer matter.";
            subheading1.Location = new Point(68, 300);
            subheading1.Text = "Parts of a Wave";
            text2.Location = new Point(68, 330);
            text2.Text = "Waves are described using the following terms:\n" +
                "•      rest position - the undisturbed position of particles or fields when they are not vibrating\n" +
                "•      displacement - the distance that a certain point in the medium has moved from its rest position\n" +
                "•      peak - the highest point above the rest position\n" +
                "•      trough - the lowest point below the rest position\n" +
                "•      amplitude - the maximum displacement of a point of a wave from its rest position\n" +
                "•      wavelength - distance covered by a full cycle of the wave, usually measured from peak to peak, or\n" +
                "       trough to trough\n" +
                "•      time period - the time taken for a full cycle of the wave, usually measured from peak to peak, or\n" +
                "       trough to trough\n" +
                "•      frequency - the number of waves passing a point each second";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = false;
        }
        private void Physics_Waves_2()
        {
            btn_Previous.Enabled = true;
            wavesSlideNo = 2;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Wave Period and Wave Speed";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic32a;
            pictureBox1.Size = new Size(472, 370);
            pictureBox1.Location = new Point(68, 120);
            text1.Location = new Point(68, 120);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            btn_Previous.Enabled = true;
        }
        private void Physics_Waves_3()
        {
            wavesSlideNo = 3;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Wave Period and Wave Speed";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic33;
            pictureBox1.Size = new Size(689, 444);
            pictureBox1.Location = new Point(68, 120);
            text1.Location = new Point(68, 120);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_4()
        {
            wavesSlideNo = 4;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Measuring the Speed of Sound in Air and Water";
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic34;
            pictureBox1.Size = new Size(760, 457);
            pictureBox1.Location = new Point(68, 120);
            text1.Location = new Point(68, 120);
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            subheading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_5()
        {
            wavesSlideNo = 5;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Longitudinal Waves";
            text1.Location = new Point(68, 120);
            text1.Text = "In longitudinal waves, the vibrations are parallel to the direction of wave travel. Examples of longitudinal waves include:\n" +
                "•      sound waves\n" +
                "•      ultrasound waves\n" +
                "•      seismic P-waves\n" +
                "One way to remember the movement of particles in longitudinal waves is to use the 'P' sound: longitudinal waves such\n" +
                "as seismic P-waves may be thought of as pressure or push waves as the particles move parallel to the wave.\n\n" +
                "Demonstrating longitudinal waves:\n" +
                "Longitudinal waves show areas of compression and rarefaction.\n" +
                "•      compressions are regions of high pressure due to particles being close together\n" +
                "•      rarefactions are regions of low pressure due to particles being spread further apart\n" +
                "Longitudinal waves are often demonstrated by pushing and pulling a stretched slinky spring.";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_6()
        {
            wavesSlideNo = 6;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Transverse Waves";
            text1.Location = new Point(68, 120);
            text1.Text = "In transverse waves, the vibrations are at right angles to the direction of wave travel. Examples of transverse waves include:\n" +
                "•      ripples on the surface of water\n" +
                "•      vibrations in a guitar string\n" +
                "•      a Mexican wave in a sports stadium\n" +
                "•      electromagnetic waves - e.g. light waves, microwaves, radio waves\n" +
                "•      seismic S-waves\n" +
                "One way to remember the movement of particles in transverse waves is to use the 'S' sound: transverse waves such as\n" +
                "seismic S-waves may be thought of as shake or shear waves as the particles move from side-to-side - crossing the\n" +
                "direction of wave travel.\n\n" +
                "Demonstrating transverse waves: Transverse waves are often demonstrated by moving a rope rapidly up and down.";
            subheading2.Text = "Electromagnetic Waves";
            subheading2.Location = new Point(68, 390);
            text2.Text = "Electromagnetic waves are transverse waves. Their vibrations or oscillations are changes in electrical and\n" +
                "magnetic fields at right angles to the direction of wave travel. All electromagnetic waves:\n" +
                "•      transfer energy as radiation from the source of the waves to an absorber\n" +
                "•     	can travel through a vacuum such as in space\n" +
                "•      travel at the same speed through a vacuum or the air\n" +
                "Electromagnetic waves travel at 300 million metres per second (m/s) through a vacuum.";
            text2.Location = new Point(68, 420);
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_7()
        {
            wavesSlideNo = 7;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Electromagnetic Spectrum";
            text1.Location = new Point(68, 120);
            text1.Text = "Electromagnetic waves form a continuous spectrum of waves. This includes\n" +
                "•      waves with a very short wavelength, high frequency and high energy\n" +
                "•      waves with a very long wavelength, low frequency and low energy\n" +
                "Electromagnetic waves can be separated into seven distinct groups in the spectrum.\n" +
                "The electromagnetic spectrum:\n" +
                "Each group contains a range of frequencies. For example, visible light contains all the frequencies that\n" +
                "can be detected by the human eye:\n" +
                "•      red light has the lowest frequencies of visible light\n" +
                "•      violet light has the highest frequencies of visible light.";
            /**/
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_8()
        {
            wavesSlideNo = 8;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Behaviour and Uses of Electromagnetic Waves";
            text1.Location = new Point(68, 120);
            text1.Text = "The behaviour of an electromagnetic wave in a substance depends on its frequency. The differing\n" +
                "behaviours of different groups in the electromagnetic spectrum make them suitable for a range of\n" +
                "uses.";
            subheading2.Location = new Point(68, 190);
            subheading2.Text = "Radio Waves";
            text2.Location = new Point(68, 220);
            text2.Text = "Radio waves are used for communication such as television and radio. Radio waves are transmitted\n" +
                "easily through air. They do not cause damage if absorbed by the human body, and they can be\n" +
                "reflected to change their direction. These properties make them ideal for communications.\n\n" +
                "Radio waves can be produced by oscillations in electrical circuits. When radio waves are\n" +
                "absorbed by a conductor, they create an alternating current. This electrical current has the same\n" +
                "frequency as the radio waves. Information is coded into the wave before transmission, which can\n" +
                "then be decoded when the wave is received. Television and radio systems use this principle to\n" +
                "broadcast information.";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_9()
        {
            wavesSlideNo = 9;
            subheading1.Location = new Point(68, 85);
            subheading1.Text = "Microwaves";
            text1.Location = new Point(68, 120);
            text1.Text = "Microwaves are used for cooking food and for satellite communications. High frequency microwaves\n" +
                "have frequencies which are easily absorbed by molecules in food. The internal energy of the\n" +
                "molecules increases when they absorb microwaves, which causes heating. Microwaves pass easily\n" +
                " through the atmosphere, so they can pass between stations on Earth and satellites in orbit.";
            subheading2.Location = new Point(68, 220);
            subheading2.Text = "Infrared";
            text2.Location = new Point(68, 250);
            text2.Text = "Infrared light is used by electrical heaters, cookers for cooking food, and by infrared cameras\n" +
                "which detect people in the dark.\n" +
                "Infrared light has frequencies which are absorbed by some chemical bonds. The internal energy\n" +
                "of the bonds increases when they absorb infrared light, which causes heating. This makes\n" +
                "infrared light useful for electrical heaters and for cooking food. All objects emit infrared\n" +
                "light. The human eye cannot see this light, but infrared cameras can detect it. This 'thermal\n" +
                "imaging' is useful for detecting people in the dark.";
            text3.Text = "";
            heading2.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_10()
        {
            wavesSlideNo = 10;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic35;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(626, 415);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false; 
        }
        private void Physics_Waves_11()
        {
            wavesSlideNo = 11;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic36;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(716,490);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_12()
        {
            wavesSlideNo = 12;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic37;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(724,517);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_13()
        {
            wavesSlideNo = 13;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic38;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(634,503);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_14()
        {
            wavesSlideNo = 14;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic39a;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(647,506);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_15()
        {
            wavesSlideNo = 15;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic40;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(783,477);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_16()
        {
            wavesSlideNo = 16;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic41;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(715,488);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_17()
        {
            wavesSlideNo = 17;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic42;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(756, 490);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_18()
        {
            wavesSlideNo = 18;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic43;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(729,518);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_19()
        {
            wavesSlideNo = 19;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic44;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(737,441);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_20()
        {
            wavesSlideNo = 20;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic45;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(755,479);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_21()
        {
            wavesSlideNo = 21;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic46;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(772,408);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_22()
        {
            wavesSlideNo = 22;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic47;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(624,472);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_23()
        {
            wavesSlideNo = 23;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic48;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(639,494);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_24()
        {
            wavesSlideNo = 24;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic49;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(639,498);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_25()
        {
            wavesSlideNo = 25;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic50;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(675,522);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_26()
        {
            wavesSlideNo = 26;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic51;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(671,503);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }
        private void Physics_Waves_27()
        {
            btn_NextSlide.Enabled = false;
            wavesSlideNo = 27;
            pictureBox1.Visible = true;
            pictureBox1.Image = Enigma_Learning.Properties.Resources.pic52;
            pictureBox1.Location = new Point(68, 85);
            pictureBox1.Size = new Size(708,487);
            subheading1.Text = "";
            text1.Text = "";
            subheading2.Text = "";
            text2.Text = "";
            text3.Text = "";
            heading2.Text = "";
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void btn_NextSlide_Click(object sender, EventArgs e)
        {
            switch (realSubjectNo)
            {
                case 1:
                    cellsSlideNo++;
                    switch (cellsSlideNo)
                    {
                        case 2:
                            Biology_Cells_2();
                            break;
                        case 3:
                            Biology_Cells_3();
                            break;
                        case 4:
                            Biology_Cells_4();
                            break;
                        case 5:
                            Biology_Cells_5();
                            break;
                        case 6:
                            Biology_Cells_6();
                            break;
                        case 7:
                            Biology_Cells_7();
                            break;
                        case 8:
                            Biology_Cells_8();
                            break;
                        case 9:
                            Biology_Cells_9();
                            break;
                        case 10:
                            Biology_Cells_10();
                            break;
                        case 11:
                            Biology_Cells_11();
                            break;
                        case 12:
                            Biology_Cells_12();
                            break;
                        case 13:
                            Biology_Cells_13();
                            break;
                        case 14:
                            Biology_Cells_14();
                            break;
                        case 15:
                            Biology_Cells_15();
                            break;
                        case 16:
                            Biology_Cells_16();
                            break;
                        case 17:
                            Biology_Cells_17();
                            break;
                        case 18:
                            Biology_Cells_18();
                            break;
                        case 19:
                            btn_NextSlide.Enabled = false;
                            Biology_Cells_19();
                            break;
                    }
                    break;
                case 2:
                    organisationSlideNo++;
                    switch (organisationSlideNo)
                    {
                        case 2:
                            btn_Previous.Enabled = true;
                            Biology_Organisation_2();
                            break;
                        case 3:
                            Biology_Organisation_3();
                            break;
                        case 4:
                            btn_NextSlide.Enabled = true;
                            Biology_Organisation_4();
                            break;
                        case 5:
                            btn_NextSlide.Enabled = false;
                            Biology_Organisation_5();
                            break;
                    }
                    break;
                case 11:
                    chemicalMeasureSlideNo++;
                    switch (chemicalMeasureSlideNo)
                    {
                        case 2:
                            btn_Previous.Enabled = true;
                            Chemical_Measurements_2();
                            break;
                        case 3:
                            Chemical_Measurements_3();
                            break;
                        case 4:
                            Chemical_Measurements_4();
                            break;
                        case 5:
                            Chemical_Measurements_5();
                            break;
                        case 6:
                            Chemical_Measurements_6();
                            break;
                        case 7:
                            Chemical_Measurements_7();
                            break;
                        case 8:
                            btn_NextSlide.Enabled = false;
                            Chemical_Measurements_8();
                            break;
                    }
                    break;
                case 12:
                    chemicalChangeSlideNo++;
                    switch (chemicalChangeSlideNo)
                    {
                        case 2:
                            Chemistry_ChemicalChange_2();
                            break;
                        case 3:
                            Chemistry_ChemicalChange_3();
                            break;
                        case 4:
                            Chemistry_ChemicalChange_4();
                            break;
                        case 5:
                            Chemistry_ChemicalChange_5();
                            break;
                        case 6:
                            Chemistry_ChemicalChange_6();
                            break;
                        case 7:
                            Chemistry_ChemicalChange_7();
                            break;
                        case 8:
                            Chemistry_ChemicalChange_8();
                            break;
                        case 9:
                            Chemistry_ChemicalChange_9();
                            break;
                        case 10:
                            Chemistry_ChemicalChange_10();
                            break;
                        case 11:
                            Chemistry_ChemicalChange_11();
                            break;
                        case 12:
                            Chemistry_ChemicalChange_12();
                            break;
                        case 13:
                            Chemistry_ChemicalChange_13();
                            break;
                        case 14:
                            Chemistry_ChemicalChange_14();
                            break;
                        case 15:
                            Chemistry_ChemicalChange_15();
                            btn_NextSlide.Enabled = false;
                            break;
                    }
                    break;
                case 21:
                    wavesSlideNo++;
                    switch(wavesSlideNo)
                    {
                        case 2:
                            Physics_Waves_2();
                            break;
                        case 3:
                            Physics_Waves_3();
                            break;
                        case 4:
                            Physics_Waves_4();
                            break;
                        case 5:
                            Physics_Waves_5();
                            break;
                        case 6:
                            Physics_Waves_6();
                            break;
                        case 7:
                            Physics_Waves_7();
                            break;
                        case 8:
                            Physics_Waves_8();
                            break;
                        case 9:
                            Physics_Waves_9();
                            break;
                        case 10:
                            Physics_Waves_10();
                            break;
                        case 11:
                            Physics_Waves_11();
                            break;
                        case 12:
                            Physics_Waves_12();
                            break;
                        case 13:
                            Physics_Waves_13();
                            break;
                        case 14:
                            Physics_Waves_14();
                            break;
                        case 15:
                            Physics_Waves_15();
                            break;
                        case 16:
                            Physics_Waves_16();
                            break;
                        case 17:
                            Physics_Waves_17();
                            break;
                        case 18:
                            Physics_Waves_18();
                            break;
                        case 19:
                            Physics_Waves_19();
                            break;
                        case 20:
                            Physics_Waves_20();
                            break;
                        case 21:
                            Physics_Waves_21();
                            break;
                        case 22:
                            Physics_Waves_22();
                            break;
                        case 23:
                            Physics_Waves_23();
                            break;
                        case 24:
                            Physics_Waves_24();
                            break;
                        case 25:
                            Physics_Waves_25();
                            break;
                        case 26:
                            Physics_Waves_26();
                            break;
                        case 27:
                            btn_NextSlide.Enabled = false;
                            Physics_Waves_27();
                            break;
                    }
                    break;

                
            }
        }

        private void btn_More_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this content is not available at the moment! Keep a " +
                "lookout at our website at https://www.enigmalearning.uk/ for information on when " +
                "an update is available", "Content not available :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /*switch (realSubjectNo)
            {
                case 1:
                    switch (cellsSlideNo)
                    {
                        case 1:
                            Process.Start("http://www.enigmalearning.uk");
                            break;
                        case 2:
                            Process.Start("http://www.youtube.com");
                            break;
                        case 3:
                            Process.Start("http://www.google.com");
                            break;
                        case 4:
                            Process.Start("http://www.wikipedia.org");
                            break;
                        case 5:
                            Process.Start("http://www.office.com");
                            break;
                        case 6:
                            Process.Start("http://www.nigeriahc.org.uk/");
                            break;
                        case 7:
                            Process.Start("http://www.maps.google.com");
                            break;
                        case 8:
                            Process.Start("http://www.translate.google.com");
                            break;
                        case 9:
                            Process.Start("http://www.gov.uk");
                            break;
                        case 10:
                            Process.Start("https://xylem-phloem.weebly.com/root-hair-cell.html");
                            break;
                        case 11:
                            Process.Start("https://xylem-phloem.weebly.com/root-hair-cell.html");
                            break;
                        case 12:
                            Process.Start("https://www.youtube.com/watch?v=YHc5SJlrJig&list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&index=75");
                            break;
                        case 13:
                            Process.Start("https://youtu.be/YHc5SJlrJig?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&t=1335");
                            break;
                        case 14:
                            Process.Start("https://www.youtube.com/watch?v=krxotllAR3E&list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&index=80");
                            break;
                        case 15:
                            Process.Start("https://www.youtube.com/watch?v=_BDRH25tzWk&list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&index=82");
                            break;
                        case 16:
                            Process.Start("https://www.youtube.com/watch?v=5fe9W1gZPUs&list=PLTJJoICRe0IsbvhD7gs5zRl6co_F1d2-l&index=4");
                            break;
                        case 17:
                            Process.Start("https://www.youtube.com/watch?v=nPEEEAamglA&list=PLTJJoICRe0IsbvhD7gs5zRl6co_F1d2-l&index=9");
                            break;
                        case 18:
                            Process.Start("https://www.youtube.com/watch?v=qyaumGW78gs&list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&index=2");
                            break;
                        case 19:
                            Process.Start("https://youtu.be/hBNagDQ0Mk8?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM");
                            break;
                    }
                    break;
                case 12:
                    switch (chemicalChangeSlideNo)
                    {
                        case 1:
                            Process.Start("https://www.youtube.com/watch?v=qxrV2pqroDY");
                            break;
                        case 2:
                            Process.Start("https://www.youtube.com/watch?v=h4sWFJFge54");
                            break;
                        case 3:
                            Process.Start("https://youtu.be/RI-HOQ27QEM?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM");
                            break;
                        case 4:
                            Process.Start("https://www.youtube.com/watch?v=UBUnnq_WtrU&list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&index=6");
                            break;
                        case 5:
                            Process.Start("https://youtu.be/E-e7U_JqWco?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM&t=174");
                            break;
                        case 6:
                            Process.Start("https://youtu.be/WkL7Fkigfn8?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM");
                            break;
                        case 7:
                            Process.Start("https://youtu.be/QDAEQFttzpM?list=PLaru1gWVa84RLdJ9kVAJFKkuplmsFvhiM");
                            break;
                        case 8:
                            Process.Start("https://www.youtube.com/watch?v=rOgPS9gFd58");
                            break;
                        case 9:
                            Process.Start("https://maternitynest.com/nigerian-baby-names-igbo-names-girls/");
                            break;
                        case 10:
                            Process.Start("https://www.youtube.com/watch?v=mYEdK4Jp91c");
                            break;
                        case 11:
                            Process.Start("https://www.thefreedictionary.com/infernal");
                            break;
                        case 12:
                            Process.Start("https://www.youtube.com/channel/UCcNWtpkE1tt-ZxijmCN0wPw");
                            break;
                        case 13:
                            Process.Start("https://www.youtube.com/watch?v=0d9r1qdsxfM");
                            break;
                        case 14:
                            Process.Start("https://www.youtube.com/watch?v=AsSh3UQ4A4c");
                            break;
                        case 15:
                            Process.Start("https://www.youtube.com/watch?v=wKorAmyMTyM");
                            break;
                    }
                    break;
                case 21:
                    switch(wavesSlideNo)
                    {
                        case 1:
                            Process.Start("https://www.youtube.com/watch?v=YHQqsx9wsnc&t=208s");
                            break;
                        case 2:
                            Process.Start("https://www.youtube.com/watch?v=34Sp0iOYank");
                            break;
                    }
                    break;
            }*/
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            btn_NextSlide.Enabled = true;
            switch (realSubjectNo)
            {
                case 1:
                    cellsSlideNo--;
                    switch (cellsSlideNo)
                    {
                        case 1:
                            Biology_Cells_1();
                            break;
                        case 2:
                            Biology_Cells_2();
                            break;
                        case 3:
                            Biology_Cells_3();
                            break;
                        case 4:
                            Biology_Cells_4();
                            break;
                        case 5:
                            Biology_Cells_5();
                            break;
                        case 6:
                            Biology_Cells_6();
                            break;
                        case 7:
                            Biology_Cells_7();
                            break;
                        case 8:
                            Biology_Cells_8();
                            break;
                        case 9:
                            Biology_Cells_9();
                            break;
                        case 10:
                            Biology_Cells_10();
                            break;
                        case 11:
                            Biology_Cells_11();
                            break;
                        case 12:
                            Biology_Cells_12();
                            break;
                        case 13:
                            Biology_Cells_13();
                            break;
                        case 14:
                            Biology_Cells_14();
                            break;
                        case 15:
                            Biology_Cells_15();
                            break;
                        case 16:
                            Biology_Cells_16();
                            break;
                        case 17:
                            Biology_Cells_17();
                            break;
                        case 18:
                            btn_NextSlide.Enabled = true;
                            Biology_Cells_18();
                            break;
                    }
                    break;
                case 2:
                    organisationSlideNo--;
                    switch (organisationSlideNo)
                    {
                        case 1:
                            btn_Previous.Enabled = false;
                            Biology_Organisation_1();
                            break;
                        case 2:
                            btn_Previous.Enabled = true;
                            Biology_Organisation_2();
                            break;
                        case 3:
                            Biology_Organisation_3();
                            break;
                        case 4:
                            btn_NextSlide.Enabled = true;
                            Biology_Organisation_4();
                            break;
                    }
                    break;
                case 11:
                    chemicalMeasureSlideNo--;
                    switch (chemicalMeasureSlideNo)
                    {
                        case 1:
                            btn_Previous.Enabled = false;
                            Chemical_Measurements_1();
                            break;
                        case 2:
                            btn_Previous.Enabled = true;
                            Chemical_Measurements_2();
                            break;
                        case 3:
                            Chemical_Measurements_3();
                            break;
                        case 4:
                            Chemical_Measurements_4();
                            break;
                        case 5:
                            Chemical_Measurements_5();
                            break;
                        case 6:
                            Chemical_Measurements_6();
                            break;
                        case 7:
                            btn_NextSlide.Enabled = true;
                            Chemical_Measurements_7();
                            break;
                    }
                    break;
                case 12:
                    chemicalChangeSlideNo--;
                    switch (chemicalChangeSlideNo)
                    {
                        case 1:
                            Chemistry_ChemicalChange_1();
                            break;
                        case 2:
                            Chemistry_ChemicalChange_2();
                            break;
                        case 3:
                            Chemistry_ChemicalChange_3();
                            break;
                        case 4:
                            Chemistry_ChemicalChange_4();
                            break;
                        case 5:
                            Chemistry_ChemicalChange_5();
                            break;
                        case 6:
                            Chemistry_ChemicalChange_6();
                            break;
                        case 7:
                            Chemistry_ChemicalChange_7();
                            break;
                        case 8:
                            Chemistry_ChemicalChange_8();
                            break;
                        case 9:
                            Chemistry_ChemicalChange_9();
                            break;
                        case 10:
                            Chemistry_ChemicalChange_10();
                            break;
                        case 11:
                            Chemistry_ChemicalChange_11();
                            break;
                        case 12:
                            Chemistry_ChemicalChange_12();
                            break;
                        case 13:
                            Chemistry_ChemicalChange_13();
                            break;
                        case 14:
                            btn_NextSlide.Enabled = true;
                            Chemistry_ChemicalChange_14();
                            break;
                    }
                    break;
                case 21:
                    wavesSlideNo--;
                    switch (wavesSlideNo)
                    {
                        case 1:
                            Physics_Waves_1();
                            break;
                        case 2:
                            Physics_Waves_2();
                            break;
                        case 3:
                            Physics_Waves_3();
                            break;
                        case 4:
                            Physics_Waves_4();
                            break;
                        case 5:
                            Physics_Waves_5();
                            break;
                        case 6:
                            Physics_Waves_6();
                            break;
                        case 7:
                            Physics_Waves_7();
                            break;
                        case 8:
                            Physics_Waves_8();
                            break;
                        case 9:
                            Physics_Waves_9();
                            break;
                        case 10:
                            Physics_Waves_10();
                            break;
                        case 11:
                            Physics_Waves_11();
                            break;
                        case 12:
                            Physics_Waves_12();
                            break;
                        case 13:
                            Physics_Waves_13();
                            break;
                        case 14:
                            Physics_Waves_14();
                            break;
                        case 15:
                            Physics_Waves_15();
                            break;
                        case 16:
                            Physics_Waves_16();
                            break;
                        case 17:
                            Physics_Waves_17();
                            break;
                        case 18:
                            Physics_Waves_18();
                            break;
                        case 19:
                            Physics_Waves_19();
                            break;
                        case 20:
                            Physics_Waves_20();
                            break;
                        case 21:
                            Physics_Waves_21();
                            break;
                        case 22:
                            Physics_Waves_22();
                            break;
                        case 23:
                            Physics_Waves_23();
                            break;
                        case 24:
                            Physics_Waves_24();
                            break;
                        case 25:
                            Physics_Waves_25();
                            break;
                        case 26:
                            btn_NextSlide.Enabled = true;
                            Physics_Waves_26();
                            break;
                    }
                    break;
            }
        }

        private void btn_More_Help_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_More_Help, "Finding it hard to understand a concept? Just use this button\n" +
                "to access explanatory videos prepared by our science team!");
        }
    }
}