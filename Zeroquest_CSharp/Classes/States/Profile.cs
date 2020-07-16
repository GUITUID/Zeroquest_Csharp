using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Profile
{

    public interface Serializable
    {
        void write(Json json);
        void read(Json json, OrderedMap<String, Object> jsonData);
    }

    public void read(Json json, OrderedMap<String, Object> jsonData)
    {
        /*playerProfile = json.readValue( "currentLevelId", Integer.class, jsonData );
        credits = json.readValue( "credits", Integer.class, jsonData );
        // libgdx handles the keys of JSON formatted HashMaps as Strings, but we
        // want it to be integers instead (because the levelIds are integers)
        Map<String,Integer> highScores = json.readValue( "highScores", HashMap.class,
            Integer.class, jsonData );
        for( String levelIdAsString : highScores.keySet() ) {
            int levelId = Integer.valueOf( levelIdAsString );
            Integer highScore = highScores.get( levelIdAsString);
            this.highScores.put( levelId, highScore );
        }*/
    }

    public static void write(String values)
    {
        FileHandle file = Gdx.files.internal ("D:/Perso/Developpement/Java/Workspaces/Zeroquest/Project/Hero_Quest/datas/player.json");
    	System.Console.WriteLine(values);
    file.writeString(values, true);
    }

	
}
