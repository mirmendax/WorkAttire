using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using attirelib;

namespace Notification
{
    public class NAttire
    {
        public string ID = Const.getId();
        string Current = string.Empty;
        public bool isDisable = false;
        public Const.TYPE_NOTIFICATION T_Count = Const.TYPE_NOTIFICATION.None;
        DateTime LastNotification = DateTime.MinValue;

        public NAttire()
        {
            this.ID = Const.getId();
            this.Current = string.Empty;
            this.isDisable = false;
            this.T_Count = Const.TYPE_NOTIFICATION.None;
        }

        public NAttire(string att)
        {
            this.ID = Const.getId(att);
            this.Current = att;
            this.isDisable = false;
            this.T_Count = Const.TYPE_NOTIFICATION.None;
        }

        public void Notification()
        {

        }

        public void Check(List<Attire> List)
        {
            foreach (var item in List)
            {
                if (item.ID == Current)
                {
                    if (item.isExtend)
                    {
                        DateTime Today = DateTime.Today;
                        switch (T_Count)
                        {
                            case Const.TYPE_NOTIFICATION.None:

                                break;
                            case Const.TYPE_NOTIFICATION.One:

                                break;
                            case Const.TYPE_NOTIFICATION.Two:

                                break;
                            case Const.TYPE_NOTIFICATION.End:

                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (T_Count)
                        {
                            case Const.TYPE_NOTIFICATION.None:

                                break;
                            case Const.TYPE_NOTIFICATION.One:

                                break;
                            case Const.TYPE_NOTIFICATION.Two:

                                break;
                            case Const.TYPE_NOTIFICATION.End:

                                break;
                            default:
                                break;
                        }
                    }
                    break;
                }
            }
        }

    }
}
