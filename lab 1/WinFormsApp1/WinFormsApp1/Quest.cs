using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Quest
    {
        public abstract string Description { get; }

        public abstract void Execute();
    }

    class FindTheLostThingQuest : Quest
    {
        public override string Description => "Find the lost thing";

        public override void Execute()
        {
            MessageBox.Show("You are on a quest to find the lost thing.");
        }
    }

    abstract class Object
    {
        public abstract string Description { get; }

        public abstract void Interact();
    }

    class LostKey : Object
    {
        public override string Description => "A lost key";

        public override void Interact()
        {
            MessageBox.Show("You have found the lost key.");
        }
    }

    class LostBook : Object
    {
        public override string Description => "A lost book";

        public override void Interact()
        {
            MessageBox.Show("You have found the lost book.");
        }
    }

    class LostPhone : Object
    {
        public override string Description => "A lost phone";

        public override void Interact()
        {
            MessageBox.Show("You have found the lost phone.");
        }
    }

    abstract class QuestFactory
    {
        public abstract Quest CreateQuest();

        public abstract Object CreateObject();
    }

    class LostKeyFactory : QuestFactory
    {
        public override Quest CreateQuest()
        {
            return new FindTheLostThingQuest();
        }

        public override Object CreateObject()
        {
            return new LostKey();
        }
    }

    class LostBookFactory : QuestFactory
    {
        public override Quest CreateQuest()
        {
            return new FindTheLostThingQuest();
        }

        public override Object CreateObject()
        {
            return new LostBook();
        }
    }

    class LostPhoneFactory : QuestFactory
    {
        public override Quest CreateQuest()
        {
            return new FindTheLostThingQuest();
        }

        public override Object CreateObject()
        {
            return new LostPhone();
        }
    }
}
