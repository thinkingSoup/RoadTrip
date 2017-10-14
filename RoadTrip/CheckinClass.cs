using System;

public class Checkin
{
    public DateTime timeStamp { get; set; }
    public Image picture { get; set; }
    public string description { get; set; }
    public CLLocation location { get; set; }
	public Checkin(DateTime _timeStamp, Image _image, string _desc, CLLocation _loc) {
        timeStamp = _timeStamp;
        picture = _image;
        description = _desc;
        location = _loc;
    }
}
