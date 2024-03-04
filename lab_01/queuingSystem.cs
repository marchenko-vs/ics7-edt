using QueuingSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QueuingSystem
{
    enum EventType
    {
        generator,
        processingDevice,
    };

    internal class queuingSystemEvents : IComparable
    {
        public EventType eventType;
        public double time;
        public int index;

        public queuingSystemEvents(EventType eventType, double time, int index)
        {
            this.eventType = eventType;
            this.time = time;
            this.index = index;
        }

        public int CompareTo(object obj)
        {
            if (obj is queuingSystemEvents queuingSystemEvent)
            {
                return Convert.ToInt32(this.time - queuingSystemEvent.time);
            }
            else
            {
                throw new ArgumentException("EXception");
            }
        }
    }

    internal class QueuingSystem
    {
        private List<Generator> generators;
        private List<Operator> processingDevices;

        private List<queuingSystemEvents> events = new List<queuingSystemEvents>();

        Queue<double> queue = new Queue<double>(0);
        public int queueSize = 0;

        public double time = 0;
        private double totalWaitingTime = 0;

        public int generated = 0;
        public int proccessed = 0;
        public double meanWaitingTime = 0;

        public QueuingSystem(List<Generator> generators,
                             List<Operator> operatingDevice)
        {
            this.generators = generators;
            this.processingDevices = operatingDevice;
        }

        public QueuingSystem(Generator generator,
                             Operator operatingDevice)
        {
            this.generators = new List<Generator>{ generator };
            this.processingDevices = new List<Operator> { operatingDevice }; ;
        }

        public void simulate(double time = 300)
        {
            totalWaitingTime = 0;
            double currentTime = 0;

            for (int i = 0; i < generators.Count; ++i)
            {
                events.Add(new queuingSystemEvents(EventType.generator, generators[i].GetTime(), i));
            }
            while (currentTime < time)
            {
                queuingSystemEvents queuingSystemEvent = events.Min();
                if (queuingSystemEvent.time + currentTime > time)
                {
                    break;
                }

                currentTime += queuingSystemEvent.time;
                reduceTime(queuingSystemEvent.time);

                if (queuingSystemEvent.eventType == EventType.generator)
                {
                    addQueueExpand(ref queue, ref queueSize);
                    queue.Enqueue(currentTime);
                    ++generated;

                    for (int i = 0; i < processingDevices.Count; ++i)
                    {
                        if (!processingDevices[i].busy)
                        {
                            totalWaitingTime += currentTime - queue.Dequeue();
                            processingDevices[i].busy = true;
                            events.Add(new queuingSystemEvents(EventType.processingDevice, processingDevices[i].GetTime(), i));
                            break;
                        }
                    }
                    events.Add(new queuingSystemEvents(EventType.generator, generators[queuingSystemEvent.index].GetTime(), queuingSystemEvent.index));
                }
                else if (queuingSystemEvent.eventType == EventType.processingDevice)
                {
                    ++proccessed;
                    if (queue.Count > 0)
                    {
                        totalWaitingTime += currentTime - queue.Dequeue();
                        events.Add(new queuingSystemEvents(EventType.processingDevice, processingDevices[queuingSystemEvent.index].GetTime(), queuingSystemEvent.index));
                    }
                    else
                    {
                        processingDevices[queuingSystemEvent.index].busy = false;
                    }
                }
                events.Remove(queuingSystemEvent);
            }

            int busyProcessingDevices = 0;
            for (int i = 0; i < processingDevices.Count; ++i)
            {
                if (processingDevices[i].busy)
                {
                    ++busyProcessingDevices;
                }
            }
            meanWaitingTime = totalWaitingTime / (proccessed + busyProcessingDevices);
        }

        private void reduceTime(double time)
        {
            foreach (var incident in events)
            {
                incident.time -= time;
            }
        }

        void addQueueExpand(ref Queue<double> queue, ref int queueSize)
        {
            if (queue.Count == queueSize)
            {
                queue = ExpandQueue(queue);
                ++queueSize;
            }
        }

        Queue<T> ExpandQueue<T>(Queue<T> queue)
        {
            int currentSize = queue.Count;
            int newSize = currentSize + 1;

            Queue<T> newQueue = new Queue<T>(newSize);
            while (queue.Count > 0)
            {
                newQueue.Enqueue(queue.Dequeue());
            }

            return newQueue;
        }
    }
}
