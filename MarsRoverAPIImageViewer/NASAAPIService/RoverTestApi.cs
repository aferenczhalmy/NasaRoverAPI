﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NasaAPIService
{
    public class RoverTestApi : RoverApi
    {
        public RoverTestApi(string endPoint) : base(endPoint)
        {
            
        }

        public override string GetImagesJson(FormattedDate formattedDate)
        {
            return "{'photos':[{'id':617458,'sol':1622,'camera':{'id':20,'name':'FHAZ','rover_id':5,'full_name':'Front Hazard Avoidance Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01622/opgs/edr/fcam/FLB_541484941EDR_F0611140FHAZ00341M_.JPG','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617459,'sol':1622,'camera':{'id':20,'name':'FHAZ','rover_id':5,'full_name':'Front Hazard Avoidance Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01622/opgs/edr/fcam/FRB_541484941EDR_F0611140FHAZ00341M_.JPG','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617460,'sol':1622,'camera':{'id':21,'name':'RHAZ','rover_id':5,'full_name':'Rear Hazard Avoidance Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01622/opgs/edr/rcam/RLB_541484975EDR_F0611140RHAZ00341M_.JPG','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617461,'sol':1622,'camera':{'id':21,'name':'RHAZ','rover_id':5,'full_name':'Rear Hazard Avoidance Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/proj/msl/redops/ods/surface/sol/01622/opgs/edr/rcam/RRB_541484975EDR_F0611140RHAZ00341M_.JPG','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617690,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083270030801249I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617691,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083270020801248I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617692,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083270010801247I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617693,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083270000801246I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617694,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083260010801245I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617695,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083260000801244I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617696,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083250030801243I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617697,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083250020801242I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617698,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083250010801241I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617699,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083250000801240I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617700,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083240010801239I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617701,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083240000801238I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617702,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083230030801237I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617703,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083230020801236I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617704,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083230010801235I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617705,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083230000801234I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617706,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083220010801233I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617707,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083220000801232I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617708,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083210030801231I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617709,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083210020801230I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617710,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083210010801229I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617711,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083210000801228I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617712,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083200010801227I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617713,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083200000801226I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617714,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083190030801225I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617715,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083190020801224I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617716,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083190010801223I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617717,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083190000801222I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617718,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083180010801221I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617719,'sol':1622,'camera':{'id':22,'name':'MAST','rover_id':5,'full_name':'Mast Camera'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mcam/1622MR0083180000801220I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617676,'sol':1622,'camera':{'id':25,'name':'MARDI','rover_id':5,'full_name':'Mars Descent Imager'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mrdi/1622MD0006290000200679E01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}},{'id':617677,'sol':1622,'camera':{'id':25,'name':'MARDI','rover_id':5,'full_name':'Mars Descent Imager'},'img_src':'http://mars.jpl.nasa.gov/msl-raw-images/msss/01622/mrdi/1622MD0006290000200679I01_DXXX.jpg','earth_date':'2017-02-27','rover':{'id':5,'name':'Curiosity','landing_date':'2012-08-06','launch_date':'2011-11-26','status':'active','max_sol':2463,'max_date':'2019-07-11','total_photos':355643,'cameras':[{'name':'FHAZ','full_name':'Front Hazard Avoidance Camera'},{'name':'NAVCAM','full_name':'Navigation Camera'},{'name':'MAST','full_name':'Mast Camera'},{'name':'CHEMCAM','full_name':'Chemistry and Camera Complex'},{'name':'MAHLI','full_name':'Mars Hand Lens Imager'},{'name':'MARDI','full_name':'Mars Descent Imager'},{'name':'RHAZ','full_name':'Rear Hazard Avoidance Camera'}]}}]}";
        }
    }
}
