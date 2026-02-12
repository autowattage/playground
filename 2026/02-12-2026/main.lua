function love.load()
  x,y,w,h,rot = 200, 200, 150, 150, 45
  heidix, heidiy = 0, 0
  heidi = love.graphics.newImage("heidi.png")
end

function love.update(dt)
  if love.keyboard.isDown("w") then y = y-5 end
  if love.keyboard.isDown("s") then y = y+5 end
  if love.keyboard.isDown("a") then x = x-5 end
  if love.keyboard.isDown("d") then x = x+5 end
  if not love.keyboard.isDown("w", "a", "s", "d") then
    x = x+math.cos(math.rad(rot))*2
    y = y+math.sin(math.rad(rot))
  end
  rot = rot + 5
  heidix = heidix + (love.mouse.getX() - heidix)*0.1
  heidiy = heidiy + (love.mouse.getY() - heidiy)*0.1
end

function love.mousepressed(x,y, button, istouch)
  love.graphics.setBackgroundColor(math.random(), math.random(), math.random(), 0)
  love.audio.play(love.audio.newSource("yippee.mp3", "static"))
end
  
function love.draw()
  love.graphics.print('Hello world', 400, 400)
  love.graphics.rectangle("fill", x,y,w,h)
  love.graphics.draw(heidi, heidix, heidiy, math.rad(rot), 0.25, 0.25, heidi:getPixelHeight()/2, heidi:getPixelWidth()/2)
end
