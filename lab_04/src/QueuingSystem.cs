using ConsoleApp1;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum EventType
    {
        generator,
        processingDevice,
    };

    internal class QueuingSystemEvents : IComparable
    {
        public EventType eventType;
        public double time;
        public int index;

        public QueuingSystemEvents(EventType eventType, double time, int index)
        {
            this.eventType = eventType;
            this.time = time;
            this.index = index;
        }

        public int CompareTo(object obj)
        {
            if (obj is QueuingSystemEvents queuingSystemEvent)
            {
                return Convert.ToInt32(this.time - queuingSystemEvent.time);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }

    internal class QueuingSystem
    {
        private readonly List<Generator> generators;
        private readonly List<Operator> operators;

        private readonly List<QueuingSystemEvents> events = [];

        Queue<double> queue = new Queue<double>(0);
        public int queueSize = 0;

        public double time = 0;
        private double totalWaitingTime = 0;

        public int generated = 0;
        public int proccessed = 0;
        public double meanWaitingTime = 0;

        public QueuingSystem(List<Generator> generators,
                             List<Operator> operators)
        {
            this.generators = generators;
            this.operators = operators;
        }

        public QueuingSystem(Generator generator,
                             Operator operators)
        {
            this.generators = new List<Generator> { generator };
            this.operators = new List<Operator> { operators }; ;
        }

        public double Simulate(double time = 300)
        {
            totalWaitingTime = 0;
            double currentTime = 0;

            for (int i = 0; i < generators.Count; ++i)
            {
                events.Add(new QueuingSystemEvents(EventType.generator, generators[i].GetTime(), i));
            }
            while (currentTime < time)
            {
                QueuingSystemEvents queuingSystemEvent = events.Min();
                if (queuingSystemEvent.time + currentTime > time)
                {
                    break;
                }

                currentTime += queuingSystemEvent.time;
                ReduceTime(queuingSystemEvent.time);

                if (queuingSystemEvent.eventType == EventType.generator)
                {
                    AddQueueExpand(ref queue, ref queueSize);
                    queue.Enqueue(currentTime);
                    ++generated;

                    for (int i = 0; i < operators.Count; ++i)
                    {
                        if (!operators[i].busy)
                        {
                            totalWaitingTime += currentTime - queue.Dequeue();
                            operators[i].busy = true;
                            if (queuingSystemEvent.index == 0)
                            {
                                events.Add(new QueuingSystemEvents(EventType.processingDevice, operators[i].GetTime1(), i));
                            }
                            else
                            {
                                events.Add(new QueuingSystemEvents(EventType.processingDevice, operators[i].GetTime2(), i));
                            }
                            break;
                        }
                    }
                    events.Add(new QueuingSystemEvents(EventType.generator, generators[queuingSystemEvent.index].GetTime(), queuingSystemEvent.index));
                }
                else if (queuingSystemEvent.eventType == EventType.processingDevice)
                {
                    ++proccessed;
                    if (queue.Count > 0)
                    {
                        totalWaitingTime += currentTime - queue.Dequeue();
                        if (queuingSystemEvent.index == 0)
                        {
                            events.Add(new QueuingSystemEvents(EventType.processingDevice, operators[queuingSystemEvent.index].GetTime1(), queuingSystemEvent.index));
                        }
                        else
                        {
                            events.Add(new QueuingSystemEvents(EventType.processingDevice, operators[queuingSystemEvent.index].GetTime2(), queuingSystemEvent.index));
                        }
                    }
                    else
                    {
                        operators[queuingSystemEvent.index].busy = false;
                    }
                }
                events.Remove(queuingSystemEvent);
            }

            int busyoperators = 0;
            for (int i = 0; i < operators.Count; ++i)
            {
                if (operators[i].busy)
                {
                    ++busyoperators;
                }
            }
            meanWaitingTime = totalWaitingTime / (proccessed + busyoperators);
            return meanWaitingTime;
        }

        private void ReduceTime(double time)
        {
            foreach (var incident in events)
            {
                incident.time -= time;
            }
        }

        void AddQueueExpand(ref Queue<double> queue, ref int queueSize)
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
