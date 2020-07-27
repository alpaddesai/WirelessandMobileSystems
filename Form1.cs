using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WirelessandMobileSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicConcepts BasicConceptsVariable = new BasicConcepts();
            BasicConceptsVariable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Introduction IntroductionVariable = new Introduction();
            IntroductionVariable.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Probability ProbabilityVariable = new Probability();
            ProbabilityVariable.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChannelCodingErrorControl ChannelCodingErrorControlVariable = new ChannelCodingErrorControl();
            ChannelCodingErrorControlVariable.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CellularConcept CellularConceptVariable = new CellularConcept();
            CellularConceptVariable.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MultipleRadioAccess MultipleRadioAccessVariable = new MultipleRadioAccess();
            MultipleRadioAccessVariable.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MultipleDivisionTech MultipleDivisionTechVariable = new MultipleDivisionTech();
            MultipleDivisionTechVariable.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModulationTechniques ModulationTechniquesVariable = new ModulationTechniques();
            ModulationTechniquesVariable.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ChannelAllocation ChannelAllocationVariable = new ChannelAllocation();
            ChannelAllocationVariable.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Mobile_Communication_Systems Mobile_Communication_SystemsVariable = new Mobile_Communication_Systems();
            Mobile_Communication_SystemsVariable.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NetworkProtocols NetworkProtocolsVariable = new NetworkProtocols();
            NetworkProtocolsVariable.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NetworkProtocolsContd NetworkProtocolsContdVariable = new NetworkProtocolsContd();
            NetworkProtocolsContdVariable.Show();
        }



        private void button15_Click(object sender, EventArgs e)
        {
            EncryptionDecryptionTechnique EncryptionDecryptionTechniqueVariable = new EncryptionDecryptionTechnique();
            EncryptionDecryptionTechniqueVariable.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WirelessLANPANBANMAN WirelessLANPANBANMANVariable = new WirelessLANPANBANMAN();
            WirelessLANPANBANMANVariable.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WPANWLANContd WPANWLANContdVariable = new WPANWLANContd();
            WPANWLANContdVariable.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            RecentAdvances RecentAdvancesVariable = new RecentAdvances();
            RecentAdvancesVariable.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Network_Simulator Network_SimulatorVariable = new Network_Simulator();
            Network_SimulatorVariable.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SensorNetworks SensorNetworksVariable = new SensorNetworks();
            SensorNetworksVariable.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ChannelCodingErrorContd ChannelCodingErrorContdVariable = new ChannelCodingErrorContd();
            ChannelCodingErrorContdVariable.Show();
        }
    }
}
